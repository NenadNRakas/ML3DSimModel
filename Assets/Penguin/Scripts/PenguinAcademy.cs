using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLAgents;
using MLAgents.Sensor;
public class PenguinAcademy : Academy
{
    /// <summary>
    /// Gets/sets the current fish speed
    /// </summary>
    public float FishSpeed { get; private set; }

    /// <summary>
    /// Gets/sets the current acceptable feed radius
    /// </summary>
    public float FeedRadius { get; private set; }
    //public float FloatProperties;
    /// <summary>
    /// Called when the academy first gets initialized
    /// </summary>
    public override void InitializeAcademy()
    {
        FishSpeed = 0f;
        FeedRadius = 0f;

        // Set up code to be called every time the fish_speed parameter changes 
        // during curriculum learning
        //FloatProperties.RegisterCallback("fish_speed", f => { FishSpeed = f; });
        //FloatProperties.RegisterCallback("fish_speed", f => { FishSpeed = f; });

        // Set up code to be called every time the feed_radius parameter changes 
        // during curriculum learning
        //FloatProperties.RegisterCallback("feed_radius", f => { FeedRadius = f; });
    }


}

