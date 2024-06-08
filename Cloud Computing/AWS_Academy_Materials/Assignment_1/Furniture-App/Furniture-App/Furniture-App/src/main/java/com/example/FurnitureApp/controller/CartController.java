package com.example.FurnitureApp.controller;

import com.example.FurnitureApp.model.Cart;
import com.example.FurnitureApp.service.CartService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class CartController {
    @Autowired
    private CartService cartService;
    @PostMapping("/create-cart")
    public ResponseEntity<Cart>createCart(){
        return ResponseEntity.ok().body(cartService.createCart());
    }

}
