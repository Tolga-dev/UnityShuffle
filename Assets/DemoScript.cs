using UnityEngine ;
using System.Collections.Generic ;

public class DemoScript : MonoBehaviour {
   [SerializeField] private int[] numbers ;
   [SerializeField] private List<string> names = new List<string> () ;

   public int shuffleTimes;
   private void Update () {
      if (Input.GetMouseButtonUp (0)) {
         numbers.Shuffle (shuffleTimes) ;
         names.Shuffle (shuffleTimes) ;
         
      }
   }
   
}


