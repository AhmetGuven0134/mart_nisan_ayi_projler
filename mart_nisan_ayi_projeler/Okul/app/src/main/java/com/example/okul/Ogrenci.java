package com.example.okul;

public class Ogrenci {
    int id;
    String adSoyad;
    int sinav1;
    int sinav2;

    public Ogrenci(int id, String adSoyad, int sinav1, int sinav2) {
        this.id = id;
        this.adSoyad = adSoyad;
        this.sinav1 = sinav1;
        this.sinav2 = sinav2;
    }

    double ortalamaHesapla() {
        return (double)(sinav1+sinav2)/2;
    }

    @Override
    public String toString() {
        return adSoyad + " Ortalama:" + ortalamaHesapla();
    }

}
