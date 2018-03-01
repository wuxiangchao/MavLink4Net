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
    /// Type of GPS fix
    /// </summary>
    /// <remarks>
    /// GPS_FIX_TYPE
    /// </remarks>
    public enum GpsFixType
    {
        
        /// <summary>
        /// No GPS connected
        /// </summary>
        /// <remarks>
        /// GPS_FIX_TYPE_NO_GPS
        /// </remarks>
        [Description("No GPS connected")]
        NoGps = 0,
        
        /// <summary>
        /// No position information, GPS is connected
        /// </summary>
        /// <remarks>
        /// GPS_FIX_TYPE_NO_FIX
        /// </remarks>
        [Description("No position information, GPS is connected")]
        NoFix = 1,
        
        /// <summary>
        /// 2D position
        /// </summary>
        /// <remarks>
        /// GPS_FIX_TYPE_2D_FIX
        /// </remarks>
        [Description("2D position")]
        _2dFix = 2,
        
        /// <summary>
        /// 3D position
        /// </summary>
        /// <remarks>
        /// GPS_FIX_TYPE_3D_FIX
        /// </remarks>
        [Description("3D position")]
        _3dFix = 3,
        
        /// <summary>
        /// DGPS/SBAS aided 3D position
        /// </summary>
        /// <remarks>
        /// GPS_FIX_TYPE_DGPS
        /// </remarks>
        [Description("DGPS/SBAS aided 3D position")]
        Dgps = 4,
        
        /// <summary>
        /// RTK float, 3D position
        /// </summary>
        /// <remarks>
        /// GPS_FIX_TYPE_RTK_FLOAT
        /// </remarks>
        [Description("RTK float, 3D position")]
        RtkFloat = 5,
        
        /// <summary>
        /// RTK Fixed, 3D position
        /// </summary>
        /// <remarks>
        /// GPS_FIX_TYPE_RTK_FIXED
        /// </remarks>
        [Description("RTK Fixed, 3D position")]
        RtkFixed = 6,
        
        /// <summary>
        /// Static fixed, typically used for base stations
        /// </summary>
        /// <remarks>
        /// GPS_FIX_TYPE_STATIC
        /// </remarks>
        [Description("Static fixed, typically used for base stations")]
        Static = 7,
        
        /// <summary>
        /// PPP, 3D position.
        /// </summary>
        /// <remarks>
        /// GPS_FIX_TYPE_PPP
        /// </remarks>
        [Description("PPP, 3D position.")]
        Ppp = 8,
    }
}