using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractHappyState : AbstractMagicalGirlState
{
	public AbstractHappyState(AbstractMagicalGirlController mg) : base(mg){}
	
	// Shoot in a specific direction
	public override void ShootStraight(Vector2 direction, float force, BulletType bulletType)
	{
		GameObject projectileObject = GameObject.Instantiate(magicalGirl.bobaBitPrefab, 
			magicalGirl.transform.position + Vector3.up * 0.5f, 
			Quaternion.identity);

        LaunchProjectiles(projectileObject, direction, force, BulletType.Boba, new BobaPatternDoNothing());
	}

}
