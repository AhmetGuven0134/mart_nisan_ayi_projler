package com.example.okul;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;

import java.util.ArrayList;
import java.util.List;

public class OgrenciAdapter extends ArrayAdapter<Ogrenci> {
    Context context;
    ArrayList<Ogrenci> ogrenciler;

    public OgrenciAdapter(Context context, ArrayList<Ogrenci> ogrenciler) {
        super(context,0,ogrenciler);
        this.context=context;
        this.ogrenciler=ogrenciler;
    }

    @NonNull
    @Override
    public View getView(int position, @Nullable View convertView, @NonNull ViewGroup parent) {
        if(convertView==null) {
            convertView = LayoutInflater.from(context).inflate(R.layout.ogrenci_item, parent, false);
        }

        Ogrenci ogrenci = getItem(position);

        TextView textAdSoyad = convertView.findViewById(R.id.textAdSoyad);
        TextView textOrtalama = convertView.findViewById(R.id.textOrtalama);

        textAdSoyad.setText(ogrenci.adSoyad);
        textOrtalama.setText("Ortalama: " + ogrenci.ortalamaHesapla());

        return convertView;
    }
}
