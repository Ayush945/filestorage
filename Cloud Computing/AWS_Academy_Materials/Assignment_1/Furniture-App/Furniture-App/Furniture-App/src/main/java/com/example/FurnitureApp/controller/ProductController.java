package com.example.FurnitureApp.controller;

import com.example.FurnitureApp.model.Product;
import com.example.FurnitureApp.service.ProductService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
public class ProductController {
    @Autowired
    private ProductService productService;
    @GetMapping("/get-all-products")
    public ResponseEntity<List<Product>> getAllProduct(){
        return ResponseEntity.ok().body(productService.getAllProduct());
    }

    @GetMapping("/get-product/{productId}")
    public ResponseEntity<Product>getProduct(@PathVariable("productId") Long productId){
        return ResponseEntity.ok().body(productService.getProduct(productId));
    }

    @PostMapping("/add-product")
    public ResponseEntity<Product>addProduct(@RequestBody Product product){
        return ResponseEntity.ok().body(productService.addProduct(product));
    }
    @DeleteMapping("/delete-product/{productId}")
    public void deleteProduct(@PathVariable("productId") Long productId){
        productService.deleteProduct(productId);
    }



}
