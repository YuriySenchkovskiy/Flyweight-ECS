using Unity.Entities;
using UnityEngine;

public class DogMoveSystem : ComponentSystem
{
    private EntityQuery _query;

    protected override void OnCreate()
    {
        //собираем на авайке наш компонент
        _query = GetEntityQuery(ComponentType.ReadOnly<DogMoveComponent>());
    }

    protected override void OnUpdate()
    {
        // двигаем каждый кадр
        Entities.With(_query).ForEach((
            Entity entity, Transform transform, DogMoveComponent dogMove) =>
        {
            var p = transform.position;
            p.y += (dogMove.MoveSpeed/100);
            transform.position = p;
        });
    }
}
