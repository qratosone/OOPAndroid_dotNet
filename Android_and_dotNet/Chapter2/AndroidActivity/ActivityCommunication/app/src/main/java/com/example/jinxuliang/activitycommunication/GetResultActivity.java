package com.example.jinxuliang.activitycommunication;

import android.content.Intent;
import android.os.Bundle;
import android.support.v7.app.ActionBarActivity;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;


public class GetResultActivity extends ActionBarActivity {

    private Button returnButton=null;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_get_result);

        TextView tView=(TextView)findViewById(R.id.receiveinfo2);
        Intent intent=getIntent();  //引用启动本Activity的那个Activity
        tView.setText(intent.getExtras().getString("info2"));

        returnButton=(Button)findViewById(R.id.return_to_mainactivity);
        returnButton.setOnClickListener(new View.OnClickListener() {


            public void onClick(View v) {
                EditText et=(EditText)findViewById(R.id.userinput);

                Intent intent=new Intent();
                intent.putExtra("result", et.getText().toString());
                setResult(RESULT_OK,intent);

            }
        });
    }


    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.menu_get_result, menu);
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
