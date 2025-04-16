package com.example.okul;

import android.content.Intent;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteStatement;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class EkleActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_ekle);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });

        SQLiteDatabase database = this.openOrCreateDatabase("okul_veritabani", MODE_PRIVATE, null);

        EditText editAdSoyad = findViewById(R.id.editAdSoyad);
        EditText editSinav1 = findViewById(R.id.editSinav1);
        EditText editSinav2 = findViewById(R.id.editSinav2);
        Button buttonEkle = findViewById(R.id.buttonEkle);

        buttonEkle.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                String adSoyad = editAdSoyad.getText().toString();
                int sinav1 = Integer.parseInt(editSinav1.getText().toString());
                int sinav2 = Integer.parseInt(editSinav2.getText().toString());

                String sorgu = "insert into ogrenciler(adSoyad, sinav1, sinav2) values(?,?,?)";
                SQLiteStatement durumlar = database.compileStatement(sorgu);
                durumlar.bindString(1, adSoyad);
                durumlar.bindLong(2,sinav1);
                durumlar.bindLong(3, sinav2);
                durumlar.execute();

                Intent intent = new Intent(getApplicationContext(), MainActivity.class);
                startActivity(intent);
            }
        });
    }
}