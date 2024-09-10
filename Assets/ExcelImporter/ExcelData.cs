using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExcelAsset]
public class ExcelData : ScriptableObject
{
	public List<PlayerMaster> PlayerMaster; // Replace 'EntityType' to an actual type that is serializable.
	public List<ObstacleMaster> ObstacleMaster; // Replace 'EntityType' to an actual type that is serializable.
}
