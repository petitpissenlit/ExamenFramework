package be.ehb.examen.model;

import javax.persistence.*;
import javax.validation.constraints.Future;
import java.time.LocalDate;
import java.time.LocalDateTime;
import java.util.ArrayList;
import java.util.List;

@Entity
public class Verhuurd {

    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private int id;

    @OneToOne
    @JoinColumn(name = "auto_id")
    private Auto autoid;


    private LocalDate startdatum;

    private LocalDate einddatum;


    @OneToOne
    @JoinColumn(name = "huurder_id")
    private Huurder huurderid;

    @Future
    public Verhuurd() {
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public Auto getAutoid() {
        return autoid;
    }

    public void setAutoid(Auto autoid) {
        this.autoid = autoid;
    }

    public LocalDate getStartdatum() {
        return startdatum;
    }

    public void setStartdatum(LocalDate startdatum) {
        this.startdatum = startdatum;
    }

    public LocalDate getEinddatum() {
        return einddatum;
    }

    public void setEinddatum(LocalDate einddatum) {
        this.einddatum = einddatum;
    }

    public Huurder getHuurderid() {
        return huurderid;
    }

    public void setHuurderid(Huurder huurderid) {
        this.huurderid = huurderid;
    }
}
