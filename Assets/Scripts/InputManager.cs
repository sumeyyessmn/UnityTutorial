using UnityEngine;

public class InputManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //[SerializeField] private GameObject _sphereGameObject;
    [SerializeField] private EnableDisable _enableDisable;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.T))
        {
            //_sphereGameObject.SetActive(true);
            _enableDisable.enabled = true;
        }
        else if(Input.GetKeyDown(KeyCode.Y))
        {
            //_sphereGameObject.SetActive(false);
            _enableDisable.enabled = false;
        }
    }
}
