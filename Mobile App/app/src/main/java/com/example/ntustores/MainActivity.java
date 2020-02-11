package com.example.ntustores;

import android.annotation.SuppressLint;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.ImageView;

import androidx.appcompat.app.AppCompatActivity;
import androidx.appcompat.widget.Toolbar;

public class MainActivity extends AppCompatActivity {

    ImageView scanImg;
    public String userNAME;
    ImageView signOut;

    @SuppressLint("ResourceAsColor")
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        Toolbar toolbar = findViewById(R.id.toolbar);
        toolbar.setTitle("");
        setSupportActionBar(toolbar);

//        toolbar.setTitle("NTU Stores");
//        toolbar.setTitleTextColor(R.color.white);

        userNAME = getIntent().getExtras().getString("userName");
       // Log.e("username1","Received username: " + userNAME); // check if username received

        scanImg = findViewById(R.id.scannerImgView);

        scanImg.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(MainActivity.this, Scanner.class);
                intent.putExtra("userName", userNAME);
                startActivity(intent);
            }
        });

        signOut = findViewById(R.id.sign_out_ic);
        signOut.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent = new Intent(MainActivity.this, Login.class);
                finish();
                startActivity(intent);
            }
        });
    }
}
