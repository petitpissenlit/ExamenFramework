package be.ehb.student_admin.controllers;


import be.ehb.student_admin.model.Product;
import be.ehb.student_admin.model.ProductDAO;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.ui.ModelMap;
import org.springframework.validation.BindingResult;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;

import javax.validation.Valid;

public class ProductController {
    private ProductDAO productDAO;

    @Autowired
    public ProductController(ProductDAO productDAO){this.productDAO = productDAO;}
    @RequestMapping(value = {"/index","/"},method = RequestMethod.GET)
    public String index(ModelMap map){return "index";}

    @ModelAttribute("producten")
    public Iterable<Product> getAllProducts(){ return productDAO.findAll();}
    @ModelAttribute("newproduct")
    public Product Product(){return new Product();}

    @GetMapping("/about")
    public String about(){return "about";}
    @GetMapping("/formulier")
    public String formulier(){return "formulier";}
    @GetMapping("/details")
    public  String details(){return "details";}
    @RequestMapping(value = {"/formulier"},method = RequestMethod.POST)
    public String saveFrom(@ModelAttribute("newproduct")@Valid Product product, BindingResult bindingResult){
        if(bindingResult.hasErrors()){
            return "formulier";
        }
        productDAO.save(product);
        return "redirect:/index";
    }


}
