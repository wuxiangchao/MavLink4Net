﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace MavLink4Net.MessageDefinitions.Tests.Data
{
    class DefinitionDataHelper
    {
        public static IEnumerable<MessageInfo> GetMessageInfos()
        {
            return new [] {
                new MessageInfo(0, "HEARTBEAT", 50, 9, 9),
                new MessageInfo(1, "SYS_STATUS", 124, 31, 31),
                new MessageInfo(2, "SYSTEM_TIME", 137, 12, 12),
                new MessageInfo(4, "PING", 237, 14, 14),
                new MessageInfo(5, "CHANGE_OPERATOR_CONTROL", 217, 28, 28),
                new MessageInfo(6, "CHANGE_OPERATOR_CONTROL_ACK", 104, 3, 3),
                new MessageInfo(7, "AUTH_KEY", 119, 32, 32),
                new MessageInfo(11, "SET_MODE", 89, 6, 6),
                new MessageInfo(20, "PARAM_REQUEST_READ", 214, 20, 20),
                new MessageInfo(21, "PARAM_REQUEST_LIST", 159, 2, 2),
                new MessageInfo(22, "PARAM_VALUE", 220, 25, 25),
                new MessageInfo(23, "PARAM_SET", 168, 23, 23),
                new MessageInfo(24, "GPS_RAW_INT", 24, 30, 50),
                new MessageInfo(25, "GPS_STATUS", 23, 101, 101),
                new MessageInfo(26, "SCALED_IMU", 170, 22, 22),
                new MessageInfo(27, "RAW_IMU", 144, 26, 26),
                new MessageInfo(28, "RAW_PRESSURE", 67, 16, 16),
                new MessageInfo(29, "SCALED_PRESSURE", 115, 14, 14),
                new MessageInfo(30, "ATTITUDE", 39, 28, 28),
                new MessageInfo(31, "ATTITUDE_QUATERNION", 246, 32, 32),
                new MessageInfo(32, "LOCAL_POSITION_NED", 185, 28, 28),
                new MessageInfo(33, "GLOBAL_POSITION_INT", 104, 28, 28),
                new MessageInfo(34, "RC_CHANNELS_SCALED", 237, 22, 22),
                new MessageInfo(35, "RC_CHANNELS_RAW", 244, 22, 22),
                new MessageInfo(36, "SERVO_OUTPUT_RAW", 222, 21, 37),
                new MessageInfo(37, "MISSION_REQUEST_PARTIAL_LIST", 212, 6, 7),
                new MessageInfo(38, "MISSION_WRITE_PARTIAL_LIST", 9, 6, 7),
                new MessageInfo(39, "MISSION_ITEM", 254, 37, 38),
                new MessageInfo(40, "MISSION_REQUEST", 230, 4, 5),
                new MessageInfo(41, "MISSION_SET_CURRENT", 28, 4, 4),
                new MessageInfo(42, "MISSION_CURRENT", 28, 2, 2),
                new MessageInfo(43, "MISSION_REQUEST_LIST", 132, 2, 3),
                new MessageInfo(44, "MISSION_COUNT", 221, 4, 5),
                new MessageInfo(45, "MISSION_CLEAR_ALL", 232, 2, 3),
                new MessageInfo(46, "MISSION_ITEM_REACHED", 11, 2, 2),
                new MessageInfo(47, "MISSION_ACK", 153, 3, 4),
                new MessageInfo(48, "SET_GPS_GLOBAL_ORIGIN", 41, 13, 21),
                new MessageInfo(49, "GPS_GLOBAL_ORIGIN", 39, 12, 20),
                new MessageInfo(50, "PARAM_MAP_RC", 78, 37, 37),
                new MessageInfo(51, "MISSION_REQUEST_INT", 196, 4, 5),
                new MessageInfo(54, "SAFETY_SET_ALLOWED_AREA", 15, 27, 27),
                new MessageInfo(55, "SAFETY_ALLOWED_AREA", 3, 25, 25),
                new MessageInfo(61, "ATTITUDE_QUATERNION_COV", 167, 72, 72),
                new MessageInfo(62, "NAV_CONTROLLER_OUTPUT", 183, 26, 26),
                new MessageInfo(63, "GLOBAL_POSITION_INT_COV", 119, 181, 181),
                new MessageInfo(64, "LOCAL_POSITION_NED_COV", 191, 225, 225),
                new MessageInfo(65, "RC_CHANNELS", 118, 42, 42),
                new MessageInfo(66, "REQUEST_DATA_STREAM", 148, 6, 6),
                new MessageInfo(67, "DATA_STREAM", 21, 4, 4),
                new MessageInfo(69, "MANUAL_CONTROL", 243, 11, 11),
                new MessageInfo(70, "RC_CHANNELS_OVERRIDE", 124, 18, 18),
                new MessageInfo(73, "MISSION_ITEM_INT", 38, 37, 38),
                new MessageInfo(74, "VFR_HUD", 20, 20, 20),
                new MessageInfo(75, "COMMAND_INT", 158, 35, 35),
                new MessageInfo(76, "COMMAND_LONG", 152, 33, 33),
                new MessageInfo(77, "COMMAND_ACK", 143, 3, 3),
                new MessageInfo(81, "MANUAL_SETPOINT", 106, 22, 22),
                new MessageInfo(82, "SET_ATTITUDE_TARGET", 49, 39, 39),
                new MessageInfo(83, "ATTITUDE_TARGET", 22, 37, 37),
                new MessageInfo(84, "SET_POSITION_TARGET_LOCAL_NED", 143, 53, 53),
                new MessageInfo(85, "POSITION_TARGET_LOCAL_NED", 140, 51, 51),
                new MessageInfo(86, "SET_POSITION_TARGET_GLOBAL_INT", 5, 53, 53),
                new MessageInfo(87, "POSITION_TARGET_GLOBAL_INT", 150, 51, 51),
                new MessageInfo(89, "LOCAL_POSITION_NED_SYSTEM_GLOBAL_OFFSET", 231, 28, 28),
                new MessageInfo(90, "HIL_STATE", 183, 56, 56),
                new MessageInfo(91, "HIL_CONTROLS", 63, 42, 42),
                new MessageInfo(92, "HIL_RC_INPUTS_RAW", 54, 33, 33),
                new MessageInfo(93, "HIL_ACTUATOR_CONTROLS", 47, 81, 81),
                new MessageInfo(100, "OPTICAL_FLOW", 175, 26, 34),
                new MessageInfo(101, "GLOBAL_VISION_POSITION_ESTIMATE", 102, 32, 32),
                new MessageInfo(102, "VISION_POSITION_ESTIMATE", 158, 32, 32),
                new MessageInfo(103, "VISION_SPEED_ESTIMATE", 208, 20, 20),
                new MessageInfo(104, "VICON_POSITION_ESTIMATE", 56, 32, 32),
                new MessageInfo(105, "HIGHRES_IMU", 93, 62, 62),
                new MessageInfo(106, "OPTICAL_FLOW_RAD", 138, 44, 44),
                new MessageInfo(107, "HIL_SENSOR", 108, 64, 64),
                new MessageInfo(108, "SIM_STATE", 32, 84, 84),
                new MessageInfo(109, "RADIO_STATUS", 185, 9, 9),
                new MessageInfo(110, "FILE_TRANSFER_PROTOCOL", 84, 254, 254),
                new MessageInfo(111, "TIMESYNC", 34, 16, 16),
                new MessageInfo(112, "CAMERA_TRIGGER", 174, 12, 12),
                new MessageInfo(113, "HIL_GPS", 124, 36, 36),
                new MessageInfo(114, "HIL_OPTICAL_FLOW", 237, 44, 44),
                new MessageInfo(115, "HIL_STATE_QUATERNION", 4, 64, 64),
                new MessageInfo(116, "SCALED_IMU2", 76, 22, 22),
                new MessageInfo(117, "LOG_REQUEST_LIST", 128, 6, 6),
                new MessageInfo(118, "LOG_ENTRY", 56, 14, 14),
                new MessageInfo(119, "LOG_REQUEST_DATA", 116, 12, 12),
                new MessageInfo(120, "LOG_DATA", 134, 97, 97),
                new MessageInfo(121, "LOG_ERASE", 237, 2, 2),
                new MessageInfo(122, "LOG_REQUEST_END", 203, 2, 2),
                new MessageInfo(123, "GPS_INJECT_DATA", 250, 113, 113),
                new MessageInfo(124, "GPS2_RAW", 87, 35, 35),
                new MessageInfo(125, "POWER_STATUS", 203, 6, 6),
                new MessageInfo(126, "SERIAL_CONTROL", 220, 79, 79),
                new MessageInfo(127, "GPS_RTK", 25, 35, 35),
                new MessageInfo(128, "GPS2_RTK", 226, 35, 35),
                new MessageInfo(129, "SCALED_IMU3", 46, 22, 22),
                new MessageInfo(130, "DATA_TRANSMISSION_HANDSHAKE", 29, 13, 13),
                new MessageInfo(131, "ENCAPSULATED_DATA", 223, 255, 255),
                new MessageInfo(132, "DISTANCE_SENSOR", 85, 14, 14),
                new MessageInfo(133, "TERRAIN_REQUEST", 6, 18, 18),
                new MessageInfo(134, "TERRAIN_DATA", 229, 43, 43),
                new MessageInfo(135, "TERRAIN_CHECK", 203, 8, 8),
                new MessageInfo(136, "TERRAIN_REPORT", 1, 22, 22),
                new MessageInfo(137, "SCALED_PRESSURE2", 195, 14, 14),
                new MessageInfo(138, "ATT_POS_MOCAP", 109, 36, 36),
                new MessageInfo(139, "SET_ACTUATOR_CONTROL_TARGET", 168, 43, 43),
                new MessageInfo(140, "ACTUATOR_CONTROL_TARGET", 181, 41, 41),
                new MessageInfo(141, "ALTITUDE", 47, 32, 32),
                new MessageInfo(142, "RESOURCE_REQUEST", 72, 243, 243),
                new MessageInfo(143, "SCALED_PRESSURE3", 131, 14, 14),
                new MessageInfo(144, "FOLLOW_TARGET", 127, 93, 93),
                new MessageInfo(146, "CONTROL_SYSTEM_STATE", 103, 100, 100),
                new MessageInfo(147, "BATTERY_STATUS", 154, 36, 36),
                new MessageInfo(148, "AUTOPILOT_VERSION", 178, 60, 78),
                new MessageInfo(149, "LANDING_TARGET", 200, 30, 60),
                new MessageInfo(150, "SENSOR_OFFSETS", 134, 42, 42),
                new MessageInfo(151, "SET_MAG_OFFSETS", 219, 8, 8),
                new MessageInfo(152, "MEMINFO", 208, 4, 8),
                new MessageInfo(153, "AP_ADC", 188, 12, 12),
                new MessageInfo(154, "DIGICAM_CONFIGURE", 84, 15, 15),
                new MessageInfo(155, "DIGICAM_CONTROL", 22, 13, 13),
                new MessageInfo(156, "MOUNT_CONFIGURE", 19, 6, 6),
                new MessageInfo(157, "MOUNT_CONTROL", 21, 15, 15),
                new MessageInfo(158, "MOUNT_STATUS", 134, 14, 14),
                new MessageInfo(160, "FENCE_POINT", 78, 12, 12),
                new MessageInfo(161, "FENCE_FETCH_POINT", 68, 3, 3),
                new MessageInfo(162, "FENCE_STATUS", 189, 8, 8),
                new MessageInfo(163, "AHRS", 127, 28, 28),
                new MessageInfo(164, "SIMSTATE", 154, 44, 44),
                new MessageInfo(165, "HWSTATUS", 21, 3, 3),
                new MessageInfo(166, "RADIO", 21, 9, 9),
                new MessageInfo(167, "LIMITS_STATUS", 144, 22, 22),
                new MessageInfo(168, "WIND", 1, 12, 12),
                new MessageInfo(169, "DATA16", 234, 18, 18),
                new MessageInfo(170, "DATA32", 73, 34, 34),
                new MessageInfo(171, "DATA64", 181, 66, 66),
                new MessageInfo(172, "DATA96", 22, 98, 98),
                new MessageInfo(173, "RANGEFINDER", 83, 8, 8),
                new MessageInfo(174, "AIRSPEED_AUTOCAL", 167, 48, 48),
                new MessageInfo(175, "RALLY_POINT", 138, 19, 19),
                new MessageInfo(176, "RALLY_FETCH_POINT", 234, 3, 3),
                new MessageInfo(177, "COMPASSMOT_STATUS", 240, 20, 20),
                new MessageInfo(178, "AHRS2", 47, 24, 24),
                new MessageInfo(179, "CAMERA_STATUS", 189, 29, 29),
                new MessageInfo(180, "CAMERA_FEEDBACK", 52, 45, 45),
                new MessageInfo(181, "BATTERY2", 174, 4, 4),
                new MessageInfo(182, "AHRS3", 229, 40, 40),
                new MessageInfo(183, "AUTOPILOT_VERSION_REQUEST", 85, 2, 2),
                new MessageInfo(184, "REMOTE_LOG_DATA_BLOCK", 159, 206, 206),
                new MessageInfo(185, "REMOTE_LOG_BLOCK_STATUS", 186, 7, 7),
                new MessageInfo(186, "LED_CONTROL", 72, 29, 29),
                new MessageInfo(191, "MAG_CAL_PROGRESS", 92, 27, 27),
                new MessageInfo(192, "MAG_CAL_REPORT", 36, 44, 44),
                new MessageInfo(193, "EKF_STATUS_REPORT", 71, 22, 22),
                new MessageInfo(194, "PID_TUNING", 98, 25, 25),
                new MessageInfo(195, "DEEPSTALL", 120, 37, 37),
                new MessageInfo(200, "GIMBAL_REPORT", 134, 42, 42),
                new MessageInfo(201, "GIMBAL_CONTROL", 205, 14, 14),
                new MessageInfo(214, "GIMBAL_TORQUE_CMD_REPORT", 69, 8, 8),
                new MessageInfo(215, "GOPRO_HEARTBEAT", 101, 3, 3),
                new MessageInfo(216, "GOPRO_GET_REQUEST", 50, 3, 3),
                new MessageInfo(217, "GOPRO_GET_RESPONSE", 202, 6, 6),
                new MessageInfo(218, "GOPRO_SET_REQUEST", 17, 7, 7),
                new MessageInfo(219, "GOPRO_SET_RESPONSE", 162, 2, 2),
                new MessageInfo(226, "RPM", 207, 8, 8),
                new MessageInfo(230, "ESTIMATOR_STATUS", 163, 42, 42),
                new MessageInfo(231, "WIND_COV", 105, 40, 40),
                new MessageInfo(232, "GPS_INPUT", 151, 63, 63),
                new MessageInfo(233, "GPS_RTCM_DATA", 35, 182, 182),
                new MessageInfo(234, "HIGH_LATENCY", 150, 40, 40),
                new MessageInfo(241, "VIBRATION", 90, 32, 32),
                new MessageInfo(242, "HOME_POSITION", 104, 52, 60),
                new MessageInfo(243, "SET_HOME_POSITION", 85, 53, 61),
                new MessageInfo(244, "MESSAGE_INTERVAL", 95, 6, 6),
                new MessageInfo(245, "EXTENDED_SYS_STATE", 130, 2, 2),
                new MessageInfo(246, "ADSB_VEHICLE", 184, 38, 38),
                new MessageInfo(247, "COLLISION", 81, 19, 19),
                new MessageInfo(248, "V2_EXTENSION", 8, 254, 254),
                new MessageInfo(249, "MEMORY_VECT", 204, 36, 36),
                new MessageInfo(250, "DEBUG_VECT", 49, 30, 30),
                new MessageInfo(251, "NAMED_VALUE_FLOAT", 170, 18, 18),
                new MessageInfo(252, "NAMED_VALUE_INT", 44, 18, 18),
                new MessageInfo(253, "STATUSTEXT", 83, 51, 51),
                new MessageInfo(254, "DEBUG", 46, 9, 9),
                new MessageInfo(256, "SETUP_SIGNING", 71, 42, 42),
                new MessageInfo(257, "BUTTON_CHANGE", 131, 9, 9),
                new MessageInfo(258, "PLAY_TUNE", 187, 32, 32),
                new MessageInfo(259, "CAMERA_INFORMATION", 122, 86, 86),
                new MessageInfo(260, "CAMERA_SETTINGS", 8, 28, 28),
                new MessageInfo(261, "STORAGE_INFORMATION", 244, 26, 26),
                new MessageInfo(262, "CAMERA_CAPTURE_STATUS", 69, 31, 31),
                new MessageInfo(263, "CAMERA_IMAGE_CAPTURED", 133, 255, 255),
                new MessageInfo(264, "FLIGHT_INFORMATION", 49, 28, 28),
                new MessageInfo(265, "MOUNT_ORIENTATION", 26, 16, 16),
                new MessageInfo(266, "LOGGING_DATA", 193, 255, 255),
                new MessageInfo(267, "LOGGING_DATA_ACKED", 35, 255, 255),
                new MessageInfo(268, "LOGGING_ACK", 14, 4, 4),
                new MessageInfo(299, "WIFI_CONFIG_AP", 19, 96, 96),
                new MessageInfo(310, "UAVCAN_NODE_STATUS", 28, 17, 17),
                new MessageInfo(311, "UAVCAN_NODE_INFO", 95, 116, 116),
                new MessageInfo(320, "PARAM_EXT_REQUEST_READ", 243, 20, 20),
                new MessageInfo(321, "PARAM_EXT_REQUEST_LIST", 88, 2, 2),
                new MessageInfo(322, "PARAM_EXT_VALUE", 243, 149, 149),
                new MessageInfo(323, "PARAM_EXT_SET", 78, 147, 147),
                new MessageInfo(324, "PARAM_EXT_ACK", 132, 146, 146),
                new MessageInfo(330, "OBSTACLE_DISTANCE", 23, 158, 158),
                new MessageInfo(10001, "UAVIONIX_ADSB_OUT_CFG", 209, 20, 20),
                new MessageInfo(10002, "UAVIONIX_ADSB_OUT_DYNAMIC", 186, 41, 41),
                new MessageInfo(10003, "UAVIONIX_ADSB_TRANSCEIVER_HEALTH_REPORT", 4, 1, 1),
                new MessageInfo(11000, "DEVICE_OP_READ", 134, 51, 51),
                new MessageInfo(11001, "DEVICE_OP_READ_REPLY", 15, 135, 135),
                new MessageInfo(11002, "DEVICE_OP_WRITE", 234, 179, 179),
                new MessageInfo(11003, "DEVICE_OP_WRITE_REPLY", 64, 5, 5),
                new MessageInfo(11010, "ADAP_TUNING", 46, 49, 49),
                new MessageInfo(11011, "VISION_POSITION_DELTA", 106, 44, 44),
                new MessageInfo(11020, "AOA_SSA", 205, 16, 16),
                new MessageInfo(42000, "ICAROUS_HEARTBEAT", 227, 1, 1),
                new MessageInfo(42001, "ICAROUS_KINEMATIC_BANDS", 239, 46, 46),
            };
        }

        public static IDictionary<uint, MessageInfo> GetMessageInfoById()
        {
            IEnumerable<MessageInfo> messageInfos = GetMessageInfos();
            IDictionary<uint, MessageInfo> messageInfoById = messageInfos.ToDictionary(i => i.MsgId, i => i);
            return messageInfoById;
        }
    }
}
