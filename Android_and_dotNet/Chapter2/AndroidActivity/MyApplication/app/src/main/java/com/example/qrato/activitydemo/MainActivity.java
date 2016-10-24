package com.example.qrato.activitydemo;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {
    private Button show=null;

    private Button receive=null;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        show=(Button)findViewById(R.id.btn_show_activity2);
        show.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent=new Intent(MainActivity.this,Main2Activity.class);
                Bundle bundle=new Bundle();
                bundle.putString("elder","toad");
                bundle.putInt("age",90);
                intent.putExtras(bundle);
                startActivity(intent);
            }
        });
        receive=(Button)findViewById(R.id.btn_send_recieve);
        receive.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent=new Intent();
                intent.setClass(MainActivity.this,Receive.class);
                startActivityForResult(intent,0);
            }
        });
    }
    protected void onActivityResult(int requestCode,int resultCode,Intent data){
        if (requestCode==0&&resultCode==RESULT_OK){
            Bundle bundle=data.getExtras();
            String resultString=bundle.getString("result");
            TextView resultTextView=(TextView)this.findViewById(R.id.resultTextView);
            resultTextView.setText("Result: "+resultString);
        }
    }
}
