package com.example.qrato.activitydemo;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.Toast;

public class Main2Activity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main2);
        Bundle bundle=this.getIntent().getExtras();
        String name=bundle.getString("elder");
        int age=bundle.getInt("age");

        Toast.makeText(this, name+String.valueOf(age), Toast.LENGTH_SHORT).show();
    }
}
