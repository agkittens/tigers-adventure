using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class win_controller : MonoBehaviour
{
    public GameObject[] buttons;
    public GameObject[] colors;
    public int[] sequence;

    public UnityEvent Check;

    bool task_1 = false;
    bool task_2 = false;
    bool task_3 = false;


    // Returns win state as array
    public int[] Status()
    {
        int[] win = {task_1 ? 1 : 0, task_2 ? 1 : 0 , task_3 ? 1 : 0 };
        return win;
    }

    // Sets internal win state
    public void LoadData(int[] win)
    {
        task_1 = win[0] != 0;
        task_2 = win[1] != 0;
        task_3 = win[2] != 0;
        Check.Invoke();
    }

    // Checks if the running puzzel has been completed
    void Buttons()
    {
        if (buttons.Length == 0) return;
        foreach (GameObject button in buttons)
        {
            if (!button.GetComponent<button_script>().isActive)
            {
                return;
            }
        }
        task_1 = true;
        Check.Invoke();

    }

    // Checks if the color sequence has been guessed
    void Colors()
    {
        if (colors.Length == 0) return;
        int i = 0;
        foreach (GameObject color in colors)
        {
            if (color.GetComponent<color_switch>().index != sequence[i])
            {
                return;
            }
            i++;
        }
        task_2 = true;
        Check.Invoke();

    }

    // Activates box challanges
    public void Boxes()
    {

        task_3 = true;
        Check.Invoke();

    }


    // Update is called once per frame
    void Update()
    {
        if (!task_1)
        {
            Buttons();

        }
        if (!task_2)
        {
            Colors();
        }

        if (task_1 && task_2 && task_3)
        {
        }
    }
}
