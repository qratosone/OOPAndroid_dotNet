package cn.edu.bit.cs.anrdemo;

import android.os.Bundle;
import android.support.v7.app.ActionBarActivity;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;


public class ANRDemo extends ActionBarActivity {

    private TextView infoTextView=null;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_anrdemo);

        infoTextView=(TextView)findViewById(R.id.txtInfo);


        Button sleepShortButton=(Button)findViewById(R.id.btnSleepShort);
        sleepShortButton.setOnClickListener(new View.OnClickListener() {

            public void onClick(View arg0) {
                try {
                    infoTextView.setText("开始休眠3秒");
                    Thread.sleep(3000);
                    infoTextView.setText("休眠3秒结束");
                } catch (InterruptedException e) {
                    e.printStackTrace();
                }
            }
        });

        Button sleepLongButton=(Button)findViewById(R.id.btnSleepLong);
        sleepLongButton.setOnClickListener(new View.OnClickListener() {


            public void onClick(View v) {
                try {
                    infoTextView.setText("开始休眠100秒");
                    Thread.sleep(100000);
                    infoTextView.setText("休眠100秒结束");
                } catch (InterruptedException e) {
                    e.printStackTrace();
                }

            }
        });
    }


    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.menu_anrdemo, menu);
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
