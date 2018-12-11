using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoShower : Interactable
{
    public Text textSlot;

    public override void StartInteraction()
    {
        textSlot.text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.Donec vestibulum iaculis bibendum. In pharetra dapibus ante, eget volutpat libero mattis ut. Donec finibus augue ac odio gravida interdum id efficitur urna. Aliquam finibus, ante molestie blandit consequat, orci justo maximus urna, consequat venenatis nunc tellus id nisi.Phasellus efficitur, sapien sed pharetra porta, tortor odio convallis risus, quis fermentum sem libero ac mauris.Sed ac massa metus. Sed quis elementum lectus. Maecenas in urna laoreet, porttitor erat quis, laoreet turpis.Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Maecenas placerat, metus eget varius convallis, nulla lorem aliquam libero, viverra pretium dolor urna a turpis.Curabitur vulputate viverra est sed euismod. Donec molestie lorem ligula, sit amet sagittis eros tristique vel.Vestibulum volutpat euismod sem, ut aliquet lacus sodales ac. Donec eget tristique erat.\n\n" +
            "Aenean fermentum massa in lacus consequat lobortis eget a nibh. Pellentesque diam purus, volutpat sed aliquam in, ultrices nec est.Aliquam lacus dolor, congue nec maximus ut, sodales a lectus. Sed dolor mi, mollis quis augue ornare, sollicitudin pretium nisl. In hac habitasse platea dictumst.Aliquam rhoncus augue lacus, et elementum augue consequat id. Maecenas cursus ligula enim, quis pretium purus dapibus et. Fusce condimentum lacus tellus, ac dapibus massa porttitor eu.\n\n" +
            "PRESS 'C' AGAIN TO CLOSE INFO";

        GameManager.instance.canvas.gameObject.SetActive(true);
        GameManager.instance.focused = true;
    }

    public override void EndInteraction()
    {
        GameManager.instance.canvas.gameObject.SetActive(false);
        GameManager.instance.focused = false;
    }
}
