package com.example.FurnitureApp.service;

import com.example.FurnitureApp.model.CartItem;
import com.example.FurnitureApp.model.Product;

import java.util.List;

public interface CartItemService {
    CartItem addToCart(Long productId);

    void deleteCartItem(Long cartItemId);

    List<CartItem> getCartItem();
}
