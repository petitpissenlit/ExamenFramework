package be.ehb.student_admin.model;

import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.validation.constraints.DecimalMin;
import javax.validation.constraints.Email;
import javax.validation.constraints.NotBlank;

@Entity
public class Product {
    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private int id;

    @NotBlank(message = " product mag niet leeg zijn!)")
    private String naam;

    @NotBlank(message = "omschrijving van het product mag niet leeg zijn!")
    private String omschrijving;

    @NotBlank(message = "Email mag niet leeg zijn!")
    @Email(message = "niet correct")
    private String email;

    @NotBlank(message = "Username mag niet leeg zijn!")
    private String username;
    @DecimalMin(value = "0.0", message = "juiste prijs gebruiken")
    private double vraagprijs;

    private String categorie;

    public Product(){

    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }
    public String getNaam(){
        return naam;
    }

    public void setNaam(String naam) {
        this.naam = naam;
    }

    public String getOmschrijving() {
        return omschrijving;
    }

    public void setOmschrijving(String omschrijving) {
        this.omschrijving = omschrijving;
    }
    public String getEmail(){
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }
    public String getUsername(){
        return username;
    }

    public void setUsername(String username) {
        this.username = username;
    }

    public double getVraagprijs() {
        return vraagprijs;
    }

    public void setVraagprijs(double vraagprijs) {
        this.vraagprijs = vraagprijs;
    }
    public String getCategorie(){
        return categorie;
    }

    public void setCategorie(String categorie) {
        this.categorie = categorie;
    }
}
