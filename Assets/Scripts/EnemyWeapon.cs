using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeapon : WeaponBase
{
    private MoveConstantly[] bulletComponents;

    public override void Shoot()
    {
        float currentTime = Time.time;

        if (currentTime - lastFiredTime > fireDelay)
        {
            // Initialize cached components array if needed
            if (bulletComponents == null || bulletComponents.Length != 3)
            {
                bulletComponents = new MoveConstantly[3];
            }

            float x = -0.5f;
            for (int i = 0; i < 3; i++)
            {
                GameObject newBullet = Instantiate(bullet, bulletSpawnPoint.position, transform.rotation);

                // Get or add the component safely
                if (!newBullet.TryGetComponent<MoveConstantly>(out MoveConstantly move))
                {
                    move = newBullet.AddComponent<MoveConstantly>();
                }

                // Store for reuse
                bulletComponents[i] = move;

                // Set direction with validation
                Vector2 direction = new Vector2(x + 0.5f * i, -0.5f);
                if (move != null)
                {
                    move.Direction = direction;
                }
                else
                {
                    Debug.LogError($"Failed to initialize MoveConstantly component on bullet {i}");
                }
            }

            lastFiredTime = currentTime;
        }
    }
}