package com.example.ntustores;

import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;

import android.annotation.SuppressLint;
import android.content.Intent;
import android.os.AsyncTask;
import android.os.Bundle;
import android.os.StrictMode;
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


        // Declare Database variables
        // ip = "000.000.000.00";
        // db = "den1.mssql7.gear.host";
        // un = "smdatabase";
        // pass = "Jj80-f1I!M3c";


        // onClick() listener for login btn
        // loginBtn.setOnClickListener(new View.OnClickListener() {
        //     @Override
        //     public void onClick(View v) {
        //         String TempUsername = userName.getText().toString();
        //         String TempPassword = password.getText().toString();
        //         if(TempUsername.equals("") || TempPassword.equals(""))
        //         {
        //             showErrorDialog("Error signing in! Please check email and password!");
        //         }
        //         else
        //         {
        //             try {
        //                 con = connectionClass(un, pass, db, ip);
        //                 if (con == null)
        //                 {
        //                     showErrorDialog("Check your internet connection!");
        //                 }
        //                 else
        //                 {
        //                     String query = "select * from User where nNumber= '" + TempUsername.toString() + "' and password = '" + TempPassword.toString();
        //                     Statement statement = con.createStatement();
        //                     ResultSet rs = statement.executeQuery(query);
        //                     if(rs.next())
        //                     {
        //                         Log.d("SQL Connection", "Login Successful!");
        //                         con.close();
        //                     }
        //                     else
        //                     {
        //                         Log.d("SQL Connection", "Login NOT Successful!");
        //                     }
        //                 }
        //             }
        //             catch (Exception ex)
        //             {
        //                 Log.d("SQL Connection", "Exception: " + ex.getMessage());
        //             }
        //         }
        //     }
        // });


    }

    public void attemptLogin(View view){
        Intent intent = new Intent(Login.this, MainActivity.class);
        finish();
        startActivity(intent);
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
