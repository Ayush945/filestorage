package com.example.FurnitureApp.repository;

import com.example.FurnitureApp.model.Cart;
import com.example.FurnitureApp.model.CartItem;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

@Repository
public interface CartRepository extends JpaRepository<Cart,Long> {

}
