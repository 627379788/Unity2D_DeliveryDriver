using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    bool hasPackage;
    [SerializeField] Color32 hasPackageColor = new Color32(1,1,1,1);
    [SerializeField] Color32 noHasPackageColor = new Color32(1,1,1,1);
    [SerializeField] float destroyTime = 30f;
    SpriteRenderer spriteRenderer;
    void Start()
    {
        hasPackage = false;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("撞到我啦");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "customer" && hasPackage) {
            hasPackage = false;
            spriteRenderer.color = noHasPackageColor;
        }else if(other.tag == "package" && !hasPackage) {
            hasPackage = true;
            Destroy(other.gameObject,destroyTime);
            spriteRenderer.color = hasPackageColor;
        }
    }
}
