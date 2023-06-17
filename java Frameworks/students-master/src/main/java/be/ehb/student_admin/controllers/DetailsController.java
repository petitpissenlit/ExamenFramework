package be.ehb.student_admin.controllers;

import be.ehb.student_admin.model.Product;
import be.ehb.student_admin.model.ProductDAO;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.ModelMap;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;

import java.util.Optional;

@Controller
public class DetailsController {
    ProductDAO productDAO;

    @Autowired
    public DetailsController(ProductDAO productDAO){this.productDAO = productDAO;}
    @RequestMapping(value = "details/{id}", method = RequestMethod.GET)

    public String Detail(ModelMap map, @PathVariable(value = "id")int id){
        Optional<Product> optional = productDAO.findById(id);

        if(optional.isPresent()){
            map.addAttribute("producten" , optional.get());
            return "details";
        }
        return "redirect:../index";
    }


}
