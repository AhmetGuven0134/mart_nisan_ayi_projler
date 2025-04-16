package com.example.okul;

import android.os.Bundle;
import android.widget.ArrayAdapter;
import android.widget.ListView;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

import java.sql.SQLData;
import java.sql.SQLIntegrityConstraintViolationException;
import java.util.ArrayList;

public class MainActivity extends AppCompatActivity {

    ArrayList<Ogrenci> ogrenciler;
    OgrenciAdapter adapter;
    ListView listView;

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
        // KESİN ÇIKAR SINAVDA !!!!
        SQLiteDatabase database = this.openOrCreateDatabase("okul_veritabani", MODE_PRIVATE, null);

        String tablo = "create tabel if  not exists ogrenciler(id integer primary key, adSoyad varchar, sinav1 integer, sinav2 integer)";
        database.exeSQL(tablo);

        ogrenciler = new ArrayList<Ogrenci>();
        String sorgu = "select * from ogrenciler"


        listView = findViewById(R.id.listView);

        ogrenciler = new ArrayList<>();
        ogrenciler.add(new Ogrenci(1, "Ahmet Yılmaz", 85, 90));
        ogrenciler.add(new Ogrenci(2, "Ayşe Kara", 78, 82));
        ogrenciler.add(new Ogrenci(3, "Mehmet Öz", 92, 88));
        ogrenciler.add(new Ogrenci(4, "Elif Demir", 75, 80));
        ogrenciler.add(new Ogrenci(5, "Ali Can", 88, 91));

        adapter = new OgrenciAdapter(this, ogrenciler);
        listView.setAdapter(adapter);


    }
}