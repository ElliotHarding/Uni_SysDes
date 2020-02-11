package com.example.ntustores;

import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;

import android.annotation.SuppressLint;
import android.content.Intent;
import android.os.AsyncTask;
import android.os.Bundle;
import android.os.StrictMode;
import android.text.TextUtils;
import android.util.Log;
import android.view.View;
import android.widget.AutoCompleteTextView;
import android.widget.Button;
import android.widget.EditText;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

public class Login extends AppCompatActivity {

    // layout variables
    AutoCompleteTextView userName;
    Button loginBtn;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_login);

        userName = findViewById(R.id.userName_EditText);
        loginBtn = findViewById(R.id.login_btn);

    }

    public void attemptLogin(View view){
        Login();

    }

    public void Login(){

        if (TextUtils.isEmpty(userName.getText().toString()))
        {
            showErrorDialog("Please type in your N number provided by the NTU!");
        }
        else
        {
            Intent intent = new Intent(Login.this, MainActivity.class);
            intent.putExtra("userName", userName.getText().toString());
            finish();
            startActivity(intent);
        }
    }

    private void showErrorDialog(String message)
    {
        new AlertDialog.Builder(this)
                .setTitle("Oops")
                .setMessage(message)
                .setPositiveButton(android.R.string.ok, null)
                .setIcon(android.R.drawable.ic_dialog_alert)
                .show();
    }
}
