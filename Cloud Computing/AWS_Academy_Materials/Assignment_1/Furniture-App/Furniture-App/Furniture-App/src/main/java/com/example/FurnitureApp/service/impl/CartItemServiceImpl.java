package com.example.FurnitureApp.service.impl;

import com.example.FurnitureApp.model.Cart;
import com.example.FurnitureApp.model.CartItem;
import com.example.FurnitureApp.model.Product;
import com.example.FurnitureApp.repository.CartItemRepository;
import com.example.FurnitureApp.repository.CartRepository;
import com.example.FurnitureApp.repository.ProductRepository;
import com.example.FurnitureApp.service.CartItemService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class CartItemServiceImpl implements CartItemService {
    @Autowired
    private CartRepository cartRepository;
    @Autowired
    private CartItemRepository cartItemRepository;

    @Autowired
    private ProductRepository productRepository;
    @Override
    public CartItem addToCart(Long productId) {
        try {
            Cart cart = cartRepository.findById(1L)
                    .orElseThrow(() -> new RuntimeException("Cart not found"));
            Product product=productRepository.findById(productId)
                    .orElseThrow(()->new RuntimeException("Product not found"));
            CartItem cartItem=new CartItem();
            cartItem.setProduct(product);
            cartItem.setCart(cart);
            return cartItemRepository.save(cartItem);
        }
        catch (Exception ex){
            Cart cart=new Cart();
            cartRepository.save(cart);
            Product product=productRepository.findById(productId)
                    .orElseThrow(()->new RuntimeException("Product not found"));
            CartItem cartItem=new CartItem();
            cartItem.setProduct(product);
            cartItem.setCart(cart);
            return cartItemRepository.save(cartItem);
        }

    }

    @Override
    public void deleteCartItem(Long cartItemId) {
        cartItemRepository.deleteById(cartItemId);
    }

    @Override
    public List<CartItem> getCartItem() {

        return cartItemRepository.findAll();
    }
}
