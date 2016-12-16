using UnityEngine;
using System.Collections;
 
public class audioManager : MonoBehaviour {
 
    //音乐文件
    public AudioSource music;
    //音量
    public float musicVolume;

	public GameObject audio;
 
    void Start() {
   		 //设置默认音量
   		 musicVolume = 0.5F;
		DontDestroyOnLoad (audio);
    }
	void OnGUI() {
 	/*
		//播放音乐按钮
		if (GUI.Button(new Rect(10, 10, 100, 50), "Play music"))  {
 
			//没有播放中
			if (!music.isPlaying){
				//播放音乐
				music.Play();
			}
 
		}
 
		//关闭音乐按钮
		if (GUI.Button(new Rect(10, 60, 100, 50), "Stop music"))  {
 
			if (music.isPlaying){
				//关闭音乐
				music.Stop();
			}
		}
		//暂停音乐
		if (GUI.Button(new Rect(10, 110, 100, 50), "Pause music"))  {
			if (music.isPlaying){
				//暂停音乐
				//这里说一下音乐暂停以后
				//点击播放音乐为继续播放
				//而停止以后在点击播放音乐
				//则为从新播放
				//这就是暂停与停止的区别
				music.Pause();
			}
		}
		*/
 
		//创建一个横向滑动条用于动态修改音乐音量
		//第一个参数 滑动条范围
		//第二个参数 初始滑块位置
		//第三个参数 起点
		//第四个参数 终点
		musicVolume = GUI.HorizontalSlider (new Rect(650, 140, 100, 50), musicVolume, 0.0F, 1.0F);
 
		//将音量的百分比打印出来
		GUI.Label(new Rect(800, 140, 300, 20),  + (int)(musicVolume * 100) + "%");
 
		if (music.isPlaying){
			//音乐播放中设置音乐音量 取值范围 0.0F到 1.0
			music.volume = musicVolume;
		}
	}
}