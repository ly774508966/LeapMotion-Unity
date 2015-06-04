﻿using UnityEngine;
using System.Collections;
using Leap;
using Sequences;

public class HandGesture : MonoBehaviour {

	private SequenceBuffer buffer = new SequenceBuffer(Game.bufferSize);

	public void AddSign(Hand hand, Frame previousFrame) {
		buffer.AddSign(Sequences.Utils.HandToSign(hand, previousFrame));
	}

	public string GetAction(Classifier classifier) {
		return classifier.ComputeToString(buffer.getSequence().GetArray());
	}
}