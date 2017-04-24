﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FaceManager : MonoBehaviour {
  public Sprite[] sprites;

  Image image;

  private void Start() {
    image = GetComponent<Image>();
  }

  public void SetHealthPercent(float p) {
    if(p >= 1) {
      image.sprite = sprites[0];
    } else if(p > 0.5f) {
      image.sprite = sprites[1];
    }else if(p > 0) {
      image.sprite = sprites[2];
    } else {
      image.sprite = sprites[3];
    }
  }
}
