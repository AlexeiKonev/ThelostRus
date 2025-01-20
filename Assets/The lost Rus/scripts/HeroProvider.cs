using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroProvider : MonoBehaviour
{
   
    public GameObject _shieldIdlebject;

    public GameObject _shieldSpecSkilloject;


  public  void StartHero()
  {
      _shieldIdlebject.SetActive(true);
      
      _shieldSpecSkilloject.SetActive(false);
  }

    // Update is called once per frame
   public void  HeroUpdate()
   {
       var xInput = Input.GetAxis("Horizontal");
       
       var yInput = Input.GetAxis("Vertical");
       
       transform.Translate(new Vector2(xInput,yInput) * Time.deltaTime);
       
   }

   public void WeaponOn()
   {
       _shieldIdlebject.SetActive(true);
      
       _shieldSpecSkilloject.SetActive(false);
   }
   public void WeaponOff()
   {
       _shieldIdlebject.SetActive(false);
      
       _shieldSpecSkilloject.SetActive(true);
   }
}
