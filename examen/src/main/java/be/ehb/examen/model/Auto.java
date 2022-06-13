package be.ehb.examen.model;

import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.validation.constraints.NotBlank;

@Entity
public class Auto {

    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private int id;

    @NotBlank
    private int chassisnr;


    @NotBlank
    private String merk;

    @NotBlank
    private String fabrikant;
    @NotBlank
    private int aantaldeuren;


    public Auto() {
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public int getChassisnr() {
        return chassisnr;
    }

    public void setChassisnr(int chassisnr) {
        this.chassisnr = chassisnr;
    }

    public String getMerk() {
        return merk;
    }

    public void setMerk(String merk) {
        this.merk = merk;
    }

    public String getFabrikant() {
        return fabrikant;
    }

    public void setFabrikant(String fabrikant) {
        this.fabrikant = fabrikant;
    }

    public int getAantaldeuren() {
        return aantaldeuren;
    }

    public void setAantaldeuren(int aantaldeuren) {
        this.aantaldeuren = aantaldeuren;
    }
}
