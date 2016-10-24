package cn.edu.bit.cs.usebutton;

import android.os.Bundle;
import android.support.v7.app.ActionBarActivity;
import android.util.Log;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.Button;
import android.widget.Toast;


public class UseButtonActivity extends ActionBarActivity {

    private Button btn1=null;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        btn1=(Button)this.findViewById(R.id.btn1);
        //使用独立的事件响应对象
        //btn1.setOnClickListener(new ButtonClick());
        //使用匿名内部类挂接事件响应代码
        btn1.setOnClickListener(new View.OnClickListener() {
            private int counter=0;
            public void onClick(View v) {

                counter++;
                //在手机上显示短暂的信息
                Toast info=Toast.makeText(UseButtonActivity.this,
                        "Button "+v.getId()+" has been clicked "+ counter + " times!",
                        Toast.LENGTH_SHORT);
                info.show();
            }
        });
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

//单独定义的事件响应代码
class ButtonClick implements View.OnClickListener{

    private int counter=0;
    public void onClick(View v) {
        counter++;
        Log.i("UseButton","I'm clicked " + counter + " times!");
    }

}