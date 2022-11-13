using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinMaxInt {

    public int min {
        get { return m_min; }
        set {
            m_min = value;
            if (m_min > max) {
                max = m_min;
            }
        }
    }
    public int m_min;
    public int max {
        get { return m_max; }
        set {
            m_max = value;
            if (m_max < min) {
                min = m_max;
            }
        }
    }
    public int m_max;
}