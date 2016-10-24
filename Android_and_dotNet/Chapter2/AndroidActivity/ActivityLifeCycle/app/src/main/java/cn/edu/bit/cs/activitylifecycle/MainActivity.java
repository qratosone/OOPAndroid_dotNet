package cn.edu.bit.cs.activitylifecycle;

import android.content.Intent;
import android.os.Bundle;
import android.support.v7.app.ActionBarActivity;
import android.util.Log;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.Button;


public class MainActivity extends ActionBarActivity {

    private final String  TAG="ActivityLifeCycle";

    private Button button1=null;
    private Button button2=null;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        Log.i(TAG, "MainActivity OnCreate");

        button1=(Button)findViewById(R.id.button1);
        button2=(Button)findViewById(R.id.button2);
        View.OnClickListener  clickListener=new OnClickListener();
        button1.setOnClickListener(clickListener);
        button2.setOnClickListener(clickListener);
    }
    private  class OnClickListener implements View.OnClickListener{


        public void onClick(View v) {
            Button btnButton =(Button)v;
            Intent intent=new Intent();
            switch (btnButton.getId()) {
                case R.id.button1:
                    intent.setClass(MainActivity.this, OneActivity.class);
                    break;
                case R.id.button2:
                    intent.setClass(MainActivity.this, TwoActivity.class);
                    break;
                default:
                    break;
            }
            MainActivity.this.startActivity(intent);

        }

    }

    @Override
    protected void onDestroy() {
        super.onDestroy();
        Log.i(TAG,"MainActivity onDestroy");
    }

    @Override
    protected void onPause() {
        super.onPause();
        Log.i(TAG,"MainActivity onPause");
    }

    @Override
    protected void onRestart() {
        super.onRestart();
        Log.i(TAG,"MainActivity onRestart");
    }

    @Override
    protected void onResume() {
        super.onResume();
        Log.i(TAG,"MainActivity onResume");
    }

    @Override
    protected void onStart() {
        super.onStart();
        Log.i(TAG,"MainActivity onStart");
    }

    @Override
    protected void onStop() {
        super.onStop();
        Log.i(TAG,"MainActivity onStop");
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
