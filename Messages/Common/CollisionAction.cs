//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;


namespace MavLink4Net.Messages.Common
{
    
    
    /// <summary>
    /// Possible actions an aircraft can take to avoid a collision.
    /// </summary>
    /// <remarks>
    /// MAV_COLLISION_ACTION
    /// </remarks>
    public enum CollisionAction
    {
        
        /// <summary>
        /// Ignore any potential collisions
        /// </summary>
        /// <remarks>
        /// MAV_COLLISION_ACTION_NONE
        /// </remarks>
        [Description("Ignore any potential collisions")]
        None = 0,
        
        /// <summary>
        /// Report potential collision
        /// </summary>
        /// <remarks>
        /// MAV_COLLISION_ACTION_REPORT
        /// </remarks>
        [Description("Report potential collision")]
        Report = 1,
        
        /// <summary>
        /// Ascend or Descend to avoid threat
        /// </summary>
        /// <remarks>
        /// MAV_COLLISION_ACTION_ASCEND_OR_DESCEND
        /// </remarks>
        [Description("Ascend or Descend to avoid threat")]
        AscendOrDescend = 2,
        
        /// <summary>
        /// Move horizontally to avoid threat
        /// </summary>
        /// <remarks>
        /// MAV_COLLISION_ACTION_MOVE_HORIZONTALLY
        /// </remarks>
        [Description("Move horizontally to avoid threat")]
        MoveHorizontally = 3,
        
        /// <summary>
        /// Aircraft to move perpendicular to the collision's velocity vector
        /// </summary>
        /// <remarks>
        /// MAV_COLLISION_ACTION_MOVE_PERPENDICULAR
        /// </remarks>
        [Description("Aircraft to move perpendicular to the collision\'s velocity vector")]
        MovePerpendicular = 4,
        
        /// <summary>
        /// Aircraft to fly directly back to its launch point
        /// </summary>
        /// <remarks>
        /// MAV_COLLISION_ACTION_RTL
        /// </remarks>
        [Description("Aircraft to fly directly back to its launch point")]
        Rtl = 5,
        
        /// <summary>
        /// Aircraft to stop in place
        /// </summary>
        /// <remarks>
        /// MAV_COLLISION_ACTION_HOVER
        /// </remarks>
        [Description("Aircraft to stop in place")]
        Hover = 6,
    }
}
