package com.example.FurnitureApp.service.impl;

import com.example.FurnitureApp.model.CartItem;
import com.example.FurnitureApp.model.Product;
import com.example.FurnitureApp.repository.CartItemRepository;
import com.example.FurnitureApp.repository.CartRepository;
import com.example.FurnitureApp.repository.ProductRepository;
import com.example.FurnitureApp.service.ProductService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class ProductServiceImpl implements ProductService {
    @Autowired
    private ProductRepository productRepository;
    @Autowired
    private CartItemRepository cartItemRepository;
    @Override
    public List<Product> getAllProduct() {
        return productRepository.findAll();
    }

    @Override
    public Product getProduct(Long productId) {
        return productRepository.findById(productId)
                .orElseThrow(()->new RuntimeException("No product found"));
    }

    @Override
    public Product addProduct(Product product) {
        return productRepository.save(product);
    }

    @Override
    public void deleteProduct(Long productId) {
        try {
            CartItem cartItem = cartItemRepository.findByProductProductId(productId)
                    .orElseThrow(() -> new RuntimeException("No product found"));
            cartItemRepository.delete(cartItem);
            productRepository.deleteById(productId);
        } catch(Exception ex) {
            productRepository.deleteById(productId);
        }
    }
}
