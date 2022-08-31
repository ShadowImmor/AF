using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum distance
{
    close,
    far,
    normal
}
public class Character : MonoBehaviour
{
    public Characters_people _charactersPeople;

    private void Start()
    {
        StartCoroutine(CoroutineSprite());
    }
    IEnumerator CoroutineSprite()
    {
        for (int i = 0; i < _charactersPeople._closeSpritesEmotions.Count; i++)
                for (int j = 1; j < _charactersPeople._closeSpritesEmotions[i]._body.Count; j++)
                    for (int k = 0; k < _charactersPeople._closeSpritesEmotions[i]._emotions.Count; k++)
                    {
                        ChangeSprite(distance.close, _charactersPeople._closeSpritesEmotions[i]._body[j].name,
                            _charactersPeople._closeSpritesEmotions[i]._emotions[k].name);
                        yield return new WaitForSeconds(0.5f);
                    }
        for (int i = 0; i < _charactersPeople._farSpritesEmotions.Count; i++)
            for (int j = 1; j < _charactersPeople._farSpritesEmotions[i]._body.Count; j++)
                for (int k = 0; k < _charactersPeople._farSpritesEmotions[i]._emotions.Count; k++)
                {
                    ChangeSprite(distance.far, _charactersPeople._farSpritesEmotions[i]._body[j].name,
                        _charactersPeople._farSpritesEmotions[i]._emotions[k].name);
                    yield return new WaitForSeconds(0.5f);
                }
        for (int i = 0; i < _charactersPeople._normalSpritesEmotions.Count; i++)
            for (int j = 0; j < _charactersPeople._normalSpritesEmotions[i]._body.Count; j++)
                for (int k = 0; k < _charactersPeople._normalSpritesEmotions[i]._emotions.Count; k++)
                {
                    ChangeSprite(distance.normal, _charactersPeople._normalSpritesEmotions[i]._body[j].name,
                        _charactersPeople._normalSpritesEmotions[i]._emotions[k].name);
                    yield return new WaitForSeconds(0.5f);
                }
    }

    public void ChangeSprite(distance _distance, string _body, string _emotion)
    {
        if (this.gameObject.transform.childCount > 0)
        {
            SpriteRenderer[] gameObjects = this.gameObject.transform.GetComponentsInChildren<SpriteRenderer>();
            for (int i = 0; i < gameObjects.Length; i++)
            {
                Destroy(gameObjects[i].gameObject);
            }
        }

        int[] indexs = SearchBodyAndEmotion(_distance, _body, _emotion);
        switch (_distance)
        {
            case (distance.close):
                {
                    Instantiate(_charactersPeople._closeSpritesEmotions[indexs[0]]._body[indexs[1]],this.gameObject.transform);
                    Instantiate(_charactersPeople._closeSpritesEmotions[indexs[0]]._emotions[indexs[2]], this.gameObject.transform);
                    break;
                }
            case (distance.far):
                {
                    Instantiate(_charactersPeople._farSpritesEmotions[indexs[0]]._body[indexs[1]], this.gameObject.transform);
                    Instantiate(_charactersPeople._farSpritesEmotions[indexs[0]]._emotions[indexs[2]], this.gameObject.transform);
                    break;
                }
            case (distance.normal):
                {
                    Instantiate(_charactersPeople._normalSpritesEmotions[indexs[0]]._body[indexs[1]], this.gameObject.transform);
                    Instantiate(_charactersPeople._normalSpritesEmotions[indexs[0]]._emotions[indexs[2]], this.gameObject.transform);
                    break;
                }
        }
    }

    public int[] SearchBodyAndEmotion(distance _distance, string _body,string _emotion)
    {
        int[] _indexs = new int[3];
        switch (_distance)
        {
            case (distance.close):
                {
                    for (int i = 0; i < _charactersPeople._closeSpritesEmotions.Count; i++)
                    {
                        for (int j = 0; j < _charactersPeople._closeSpritesEmotions[i]._body.Count; j++)
                            if (_charactersPeople._closeSpritesEmotions[i]._body[j].name.Contains(_body))
                            {
                                _indexs[0] = i;
                                _indexs[1] = j;
                                for (int k = 0; k < _charactersPeople._closeSpritesEmotions[i]._emotions.Count; k++)
                                {
                                    if (_charactersPeople._closeSpritesEmotions[i]._emotions[k].name.Contains(_emotion))
                                    {
                                        _indexs[2] = k;
                                        return _indexs;
                                    }
                                }
                            }
                    }
                    break;
                }
            case (distance.far):
                {
                    for (int i = 0; i < _charactersPeople._farSpritesEmotions.Count; i++)
                    {
                        for (int j = 0; j < _charactersPeople._farSpritesEmotions[i]._body.Count; j++)
                            if (_charactersPeople._farSpritesEmotions[i]._body[j].name.Contains(_body))
                            {
                                _indexs[0] = i;
                                _indexs[1] = j;
                                for (int k = 0; k < _charactersPeople._farSpritesEmotions[i]._emotions.Count; k++)
                                {
                                    if (_charactersPeople._farSpritesEmotions[i]._emotions[k].name.Contains(_emotion))
                                    {
                                        _indexs[2] = k;
                                        return _indexs;
                                    }
                                }
                            }
                    }
                    break;
                }
            case (distance.normal):
                {
                    for (int i = 0; i < _charactersPeople._normalSpritesEmotions.Count; i++)
                    {
                        for (int j = 0; j < _charactersPeople._normalSpritesEmotions[i]._body.Count; j++)
                            if (_charactersPeople._normalSpritesEmotions[i]._body[j].name.Contains(_body))
                            {
                                _indexs[0] = i;
                                _indexs[1] = j;
                                for (int k = 0; k < _charactersPeople._normalSpritesEmotions[i]._emotions.Count; k++)
                                {
                                    if (_charactersPeople._normalSpritesEmotions[i]._emotions[k].name.Contains(_emotion))
                                    {
                                        _indexs[2] = k;
                                        return _indexs;
                                    }
                                }
                            }
                    }
                    break;
                }
        }
        
        return _indexs;
    }
}
