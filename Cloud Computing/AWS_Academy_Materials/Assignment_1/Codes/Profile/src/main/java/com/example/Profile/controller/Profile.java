package com.example.Profile.controller;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;


@Controller
public class Profile {

    @GetMapping("/homepage")
    public String homepage(){
        return "homepage";
    }
}
