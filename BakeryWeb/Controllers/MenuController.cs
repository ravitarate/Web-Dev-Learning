using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using BakeryWeb.Models;

namespace BakeryWeb.Controllers;

public class MenuController : Controller
{
    private static readonly List<Category> Categories = new()
    {
        new Category { Id = 1, Name = "Savory Snacks", Description = "Perfect evening snacks with chai" },
        new Category { Id = 2, Name = "Biscuits & Cookies", Description = "Classic Pune bakery style biscuits" },
        new Category { Id = 3, Name = "Cakes & Pastries", Description = "Freshly baked sweet treats" }
    };

    private static readonly List<Product> Products = new()
    {
        new Product { Id = 1, Name = "व्हेज पफ (Veg Puff)", Description = "गरमागरम आणि कुरकुरीत व्हेज पफ, मसालेदार बटाटा आणि भाज्यांच्या सारणासह. पुण्याची खास ओळख.", Price = 20.00m, ImageUrl = "https://images.unsplash.com/photo-1600109033364-70a27318721c?q=80&w=1470&auto=format&fit=crop", CategoryId = 1, Category = Categories[0] },
        new Product { Id = 2, Name = "पुणेरी मिनी समोसा", Description = "चटपटीत आणि खुसखुशीत पुण्याचा प्रसिद्ध मिनी समोसा. चहाबरोबर खाण्यासाठी उत्तम.", Price = 15.00m, ImageUrl = "https://images.unsplash.com/photo-1601050690597-df0568f70950?q=80&w=1471&auto=format&fit=crop", CategoryId = 1, Category = Categories[0] },
        new Product { Id = 3, Name = "मावा केक (Mawa Cake)", Description = "ताज्या माव्यापासून बनवलेला मऊ आणि चविष्ट केक, वेलचीच्या सुगंधासह.", Price = 120.00m, ImageUrl = "https://images.unsplash.com/photo-1578985545062-69928b1d9587?q=80&w=1489&auto=format&fit=crop", CategoryId = 3, Category = Categories[2] },
        new Product { Id = 4, Name = "खारी बिस्कीट (Khari Biscuit)", Description = "थेट ओव्हनमधून आलेली, एकदम हलकी आणि कुरकुरीत खारी. गरमागरम चहाची उत्तम जोडीदार.", Price = 80.00m, ImageUrl = "https://plus.unsplash.com/premium_photo-1663853051662-6029a8a3ce2a?q=80&w=1470&auto=format&fit=crop", CategoryId = 2, Category = Categories[1] },
        new Product { Id = 5, Name = "श्रुस्बरी बिस्कीट (Shrewsbury)", Description = "पुण्याची शान असलेले, तोंडात विरघळणारे खास बटर कुकीज.", Price = 150.00m, ImageUrl = "https://images.unsplash.com/photo-1499636136210-6f4ee915583e?q=80&w=1364&auto=format&fit=crop", CategoryId = 2, Category = Categories[1] },
        new Product { Id = 6, Name = "ब्लॅक फॉरेस्ट पेस्ट्री", Description = "चॉकलेट स्पंज, फ्रेश क्रीम आणि चेरीने सजवलेली मऊ पेस्ट्री.", Price = 60.00m, ImageUrl = "https://images.unsplash.com/photo-1578985545062-69928b1d9587?q=80&w=1489&auto=format&fit=crop", CategoryId = 3, Category = Categories[2] },
        new Product { Id = 7, Name = "बन मस्का (Bun Maska)", Description = "मऊ आणि गोड बन, भरपूर ताज्या लोण्यासोबत. एकदम कडक चहा सोबत खाण्याची मजाच वेगळी!", Price = 30.00m, ImageUrl = "https://images.unsplash.com/photo-1509440159596-0249088772ff?q=80&w=1472&auto=format&fit=crop", CategoryId = 1, Category = Categories[0] }
    };

    public IActionResult Index()
    {
        return View(Products);
    }
}
