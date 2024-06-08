package com.example.FurnitureApp.service.impl;

import com.example.FurnitureApp.model.Cart;
import com.example.FurnitureApp.repository.CartRepository;
import com.example.FurnitureApp.service.CartService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class CartServiceImpl implements CartService {
    @Autowired
    private CartRepository cartRepository;
    @Override
    public Cart createCart() {
        Cart cart=new Cart();
        cart.setTotalPrice(0D);
        return cartRepository.save(cart);
    }
}
