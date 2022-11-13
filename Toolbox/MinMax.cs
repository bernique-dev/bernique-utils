using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinMax {

    public float min {
        get { return m_min; }
        set {
            m_min = value;
            if (m_min > max) {
                max = m_min;
            }
        }
    }
    public float m_min;
    public float max {
        get { return m_max; }
        set {
            m_max = value;
            if (m_max < min) {
                min = m_max;
            }
        }
    }
    public float m_max;
}