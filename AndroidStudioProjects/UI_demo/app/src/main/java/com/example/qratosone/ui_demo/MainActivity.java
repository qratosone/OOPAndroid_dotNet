package com.example.qratosone.ui_demo;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity {
    private Button button;
    private EditText editText;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        button=(Button)findViewById(R.id.btn1);
        editText=(EditText)findViewById(R.id.edit_text);
        button.setOnClickListener(new View.OnClickListener(){
            public void onClick(View v){
                String input_text=editText.getText().toString();
                Toast.makeText(MainActivity.this,input_text,Toast.LENGTH_SHORT).show();
            }
        });
    }
}
