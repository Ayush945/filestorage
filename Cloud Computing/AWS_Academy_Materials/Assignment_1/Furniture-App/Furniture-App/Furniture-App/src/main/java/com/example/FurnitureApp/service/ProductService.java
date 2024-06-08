package com.example.FurnitureApp.service;

import com.example.FurnitureApp.model.Product;

import java.util.List;

public interface ProductService {

   List<Product> getAllProduct();

    Product getProduct(Long productId);

    Product addProduct(Product product);

    void deleteProduct(Long productId);
}
