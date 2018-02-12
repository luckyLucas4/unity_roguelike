﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour {

    public Sprite dmgSprite;
    public int hp = 4;

    public AudioClip chopsound1;
    public AudioClip chopsound2;

    private SpriteRenderer spriteRenderer;

	// Use this for initialization
	void Awake ()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
	}
	
    public void DamageWall(int loss)
    {
        SoundManager.instance.RandomizeSfx(chopsound1, chopsound2);
        spriteRenderer.sprite = dmgSprite;
        hp -= loss;
        if (hp <= 0)
            gameObject.SetActive(false);
    }
}
