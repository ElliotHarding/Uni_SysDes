package com.example.ntustores;

import android.Manifest;
import android.content.Intent;
import android.os.AsyncTask;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Toast;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

import com.budiyev.android.codescanner.CodeScanner;
import com.budiyev.android.codescanner.CodeScannerView;
import com.budiyev.android.codescanner.DecodeCallback;
import com.google.zxing.Result;
import com.karumi.dexter.Dexter;
import com.karumi.dexter.PermissionToken;
import com.karumi.dexter.listener.PermissionDeniedResponse;
import com.karumi.dexter.listener.PermissionGrantedResponse;
import com.karumi.dexter.listener.PermissionRequest;
import com.karumi.dexter.listener.single.PermissionListener;

import java.io.InputStream;
import java.io.OutputStreamWriter;
import java.net.URL;
import java.net.URLConnection;
import java.nio.charset.StandardCharsets;
import java.util.concurrent.Callable;

import org.apache.commons.io.IOUtils;

public class Scanner extends AppCompatActivity {

    private final String m_dbPostUrl = "http://stockmanagersystem.gearhostpreview.com/dbPost.php";
    CodeScanner mCodeScanner;
    CodeScannerView mScannerView;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_scanner);

        mScannerView = findViewById(R.id.scannerView);
        mCodeScanner = new CodeScanner(this,mScannerView);


        // Once the QR code has been detected in the scanner view it will decode that
        mCodeScanner.setDecodeCallback(new DecodeCallback() {
            @Override
            public void onDecoded(@NonNull final Result result) { // once the qr code has been decoded it will be stores in the result variable


                runOnUiThread(new Runnable() { // will allow the user to scan multiple times without going off the scannerView
                    @Override
                    public void run() {
                        BaseCallback baseCallback = new BaseCallback();
                      //  baseCallback.nNumber = getIntent().getExtras().getString("userName");
                        baseCallback.nNumber = getIntent().getExtras().getString("userName"); // getting username from main acclivity which got it from login page
                        baseCallback.pid = result.toString();
                        new UploadData().execute(baseCallback);



                    }
                });

            }
        });

        mScannerView.setOnClickListener(new View.OnClickListener() { // when the user clicks on the scannerView (after the scanner finishes taking a qr code) run the following code
            @Override
            public void onClick(View view) {
                mCodeScanner.startPreview(); // re-start the qr scanner view to allow user to scan again
            }
        });
    }

    @Override
    protected void onResume(){
        super.onResume();
        requestCamera(); // Ask for permission
    }

    private void requestCamera() {
        Dexter.withActivity(this).withPermission(Manifest.permission.CAMERA).withListener(new PermissionListener() { // if permission is granted run the following code
            @Override
            public void onPermissionGranted(PermissionGrantedResponse response) {
                mCodeScanner.startPreview(); // start qr scanner view

            }

            @Override
            public void onPermissionDenied(PermissionDeniedResponse response) { // run following code if user declines
                Toast.makeText(Scanner.this, "Camera Permission is Required!", Toast.LENGTH_SHORT).show();

            }

            @Override
            public void onPermissionRationaleShouldBeShown(PermissionRequest permission, PermissionToken token) {
                token.continuePermissionRequest();// keep asking for permission until user accepts
            }
        }).check();
    }

    private class UploadData extends AsyncTask<BaseCallback, String, String>
    {
        @Override
        protected String doInBackground(BaseCallback... params)
        {
            try
            {
                Log.e("APIConnection","function accessed");
                URLConnection connection = new URL(m_dbPostUrl+"?nNumber=" + params[0].nNumber + "&pid="+params[0].pid).openConnection();
                connection.setDoOutput(true);
                InputStream res = connection.getInputStream();
                String result = IOUtils.toString(res, StandardCharsets.UTF_8);
                Log.e("APIConnection","Connection result" + result);
//
                if (result.equals("null"))
                {
                    params[0].success = true;
                }

            }
            catch (Exception e)
            {
                Log.e("APIConnection", e.getMessage());
                params[0].success = false;
            }

            try
            {
                params[0].call();
            }
            catch (Exception e)
            {
                e.printStackTrace();
            }

            return "Executed";
        }
    }



    public class BaseCallback implements Callable<Void>
    {
        public String pid;
        public String nNumber;
        public boolean success;

        @Override
        public Void call() throws Exception
        {
            if(success)
            {
                // call run on ui thread and notify user
                runOnUiThread(new Runnable() {
                    @Override
                    public void run() {
                        Toast.makeText(Scanner.this,"Scanned Successfully! Tap screen to scan again!", Toast.LENGTH_LONG).show();
                    }
                });
            }

            return null;
        }
    }
}
