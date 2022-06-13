package be.ehb.examen.controller;

import be.ehb.examen.model.*;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.*;

import javax.persistence.JoinColumn;
import java.time.LocalDate;

@Controller
public class controller {

    AutoDao autoDao;

    HuurderDao huurderDao;

    VerhuurdDao verhuurdDao;

    @Autowired

    public controller(AutoDao autoDao, HuurderDao huurderDao, VerhuurdDao verhuurdDao) {
        this.autoDao = autoDao;
        this.huurderDao = huurderDao;
        this.verhuurdDao = verhuurdDao;
    }

    //opvraging alle auto's

    @RequestMapping(value = "/auto",method = RequestMethod.GET)
    @ResponseBody
    public Iterable<Auto> FindAll(){
        return autoDao.findAll();
    }
//geprobeerd om deze op te roepen met de fabrikant-id en dan een andere oplossing gezocht, maar heb veel tijd verloren in het zoeken, ik heb iets geprobeerd, maar is niet gelukt.

    @RequestMapping(value = "/fabrikant",method = RequestMethod.GET)
    public String giveallautos(@PathVariable("fabrikant") String fabrikant){
        String toString = autoDao.toString();


        return toString;
    }
    //opvraging van alle verhuurders
    @RequestMapping(value = "/verhuurd",method = RequestMethod.GET)
    @ResponseBody
    public Iterable<Verhuurd> findAll(){
        return verhuurdDao.findAll();
    }

    @RequestMapping(value = "/nieuwehuurder",method = RequestMethod.POST)
    public HttpStatus nieuwehuurder(@RequestParam("id")int id,
                                    @RequestParam("naam") String naam,
                                    @RequestParam("achternaam") String achternaam,
                                    @RequestParam("email") String email,
                                    @RequestParam("telefoonnummer") int telefoonnummer{
        if(huurderDao.existsById(id)){
            Huurder nieuwehuurder = new Huurder();
            nieuwehuurder.setId(id);
            nieuwehuurder.setNaam(naam);
            nieuwehuurder.setAchternaam(achternaam);
            nieuwehuurder.setEmail(email);
            nieuwehuurder.setTelefoonnummer(telefoonnummer);
            huurderDao.save(nieuwehuurder);
            return HttpStatus.ACCEPTED;

        }
        return HttpStatus.NOT_ACCEPTABLE;
    }


    @RequestMapping(value = "/verhuurdeAutos",method = RequestMethod.GET)
    public Iterable<Verhuurd> verhuurdeAutos(){
        //niet genoeg tijd om deze af te werken mijn bedoeling was om een if statement te maken met de startdatum als deze begint telt deze als verhuurd en voor einddatum om deze weg te laten
    }





}
