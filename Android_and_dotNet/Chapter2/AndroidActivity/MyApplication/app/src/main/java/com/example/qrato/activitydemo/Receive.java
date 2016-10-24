package com.example.qrato.activitydemo;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

public class Receive extends AppCompatActivity {
    private Button returnButton=null;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_receive);
        Intent intent=getIntent();//获取启动者传送的Intent
        returnButton=(Button)findViewById(R.id.btn_send_back);
        returnButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                EditText et=(EditText)findViewById(R.id.getText);
                Intent intent=new Intent();
                intent.putExtra("result",et.getText().toString());
                setResult(RESULT_OK,intent);
                finish();
            }
        });
    }
}
