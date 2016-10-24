package com.example.jinxuliang.onetooneobjectembedandroiddemo;

import android.app.Activity;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;


public class MainActivity extends Activity {

    private Button clickMeButton=null;
    private TextView infoTextView=null;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        init();
    }

    /**
     * 初始化界面控件
     */
    private void init(){
        infoTextView=(TextView)findViewById(R.id.tvInfo);
        showCounter(0);
        clickMeButton=(Button)findViewById(R.id.btnClickMe);
        clickMeButton.setOnClickListener(new View.OnClickListener() {
            private int counter=0;
            @Override
            public void onClick(View v) {

                showCounter(++counter);
            }
        });
    }

    private void showCounter(int counter){
        infoTextView.setText(String.format("按钮被单击了%1$d次",counter));
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
