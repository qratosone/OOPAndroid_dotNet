package com.example.jinxuliang.activitycommunication;

import android.content.Intent;
import android.os.Bundle;
import android.support.v7.app.ActionBarActivity;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;


public class MainActivity extends ActionBarActivity {

    //用于区分多个按钮的请求
    private final static int REQUEST_CODE = 1;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        Button showSecond = (Button) findViewById(R.id.showSecondActivity);
        showSecond.setOnClickListener(new View.OnClickListener() {


            public void onClick(View v) {
                Intent intent = new Intent();
                intent.setClass(MainActivity.this, SecondActivity.class);
                startActivity(intent);
            }
        });

        Button receiveButton = (Button) findViewById(R.id.passInfomation);
        receiveButton.setOnClickListener(new View.OnClickListener() {

            public void onClick(View v) {
                Intent intent = new Intent();
                intent.setClass(MainActivity.this, ReceiveInfoActivity.class);
                intent.putExtra("info", "老大向老二问好！");
                startActivity(intent);
            }
        });

        Button resultButton = (Button) findViewById(R.id.getResult);
        resultButton.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v) {
                Intent intent = new Intent();
                intent.setClass(MainActivity.this, GetResultActivity.class);
                intent.putExtra("info2", "老大说：我需要你提供一点信息：");
                //指定一个请求id
                startActivityForResult(intent, REQUEST_CODE);
            }
        });
    }

    @Override
    protected void onActivityResult(int requestCode, int resultCode, Intent data) {
        if (requestCode == REQUEST_CODE && resultCode == RESULT_OK) {
            Bundle bundle = data.getExtras();
            String resultString = bundle.getString("result");
            TextView resultTextView=(TextView) this.findViewById(R.id.tvResult);
            resultTextView.setText("得到结果："+resultString);

        }
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.menu_main, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        // Handle action bar item clicks here. The action bar will
        // automatically handle clicks on the Home/Up button, so long
        // as you specify a parent activity in AndroidManifest.xml.
        int id = item.getItemId();

        //noinspection SimplifiableIfStatement
        if (id == R.id.action_settings) {
            return true;
        }

        return super.onOptionsItemSelected(item);
    }
}
