package com.example.okul;

import android.content.Intent;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.os.Bundle;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.ListView;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

import java.util.ArrayList;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });

        SQLiteDatabase database = this.openOrCreateDatabase("okul_veritabani", MODE_PRIVATE, null);

        String tablo = "create table if not exists ogrenciler(id integer primary key, adSoyad varchar, sinav1 integer, sinav2 integer)";
        database.execSQL(tablo);

        ArrayList<Ogrenci> ogrenciler = new ArrayList<>();
        String sorgu = "select * from ogrenciler";
        Cursor cursor = database.rawQuery(sorgu, null);
        while(cursor.moveToNext()) {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.id= cursor.getInt(0);
            ogrenci.adSoyad= cursor.getString(1);;
            ogrenci.sinav1= cursor.getInt(2);
            ogrenci.sinav2= cursor.getInt(3);
            ogrenciler.add(ogrenci);
        }

        ListView listView = findViewById(R.id.listView);
        OgrenciAdapter adapter = new OgrenciAdapter(this, ogrenciler);
        listView.setAdapter(adapter);

        Button buttonYeni = findViewById(R.id.buttonYeni);
        buttonYeni.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(getApplicationContext(), EkleActivity.class);
                startActivity(intent);
            }
        });


    }
}