package com.example.FurnitureApp.controller;

import com.example.FurnitureApp.model.CartItem;
import com.example.FurnitureApp.model.Product;
import com.example.FurnitureApp.service.CartItemService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
public class CartItemController {
    @Autowired
    private CartItemService cartItemService;
    @GetMapping("get-cart-item")
    public ResponseEntity<List<CartItem>>getCartItem(){
        return ResponseEntity.ok().body(cartItemService.getCartItem());
    }


    @PostMapping("add-to-cart/{productId}")
    public ResponseEntity<CartItem> addToCart(@PathVariable("productId")Long productId){
        return ResponseEntity.ok().body(cartItemService.addToCart(productId));
    }

    @DeleteMapping("delete-from-cart/{cartItemId}")
    public void deleteCartItem(@PathVariable("cartItemId") Long cartItemId){
        cartItemService.deleteCartItem(cartItemId);
    }
}
