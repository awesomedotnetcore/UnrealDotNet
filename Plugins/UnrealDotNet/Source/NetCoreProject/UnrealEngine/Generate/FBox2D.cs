using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Implements a rectangular 2D Box.
	/// </summary>
	public partial struct FBox2D
	{
		
		#region DLLInmport
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern FVector2D E_OP_FBox2D_oc(FBox2D Self, int Index);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_FBox2D_ComputeSquaredDistanceToPoint(FBox2D Self, FVector2D Point);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern FBox2D E_FBox2D_ExpandBy(FBox2D Self, float W);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_FBox2D_GetArea(FBox2D Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern FVector2D E_FBox2D_GetCenter(FBox2D Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_FBox2D_GetCenterAndExtents(FBox2D Self, FVector2D center, FVector2D Extents);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern FVector2D E_FBox2D_GetClosestPointTo(FBox2D Self, FVector2D Point);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_FBox2D_Init(FBox2D Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_FBox2D_IsInside(FBox2D Self, FVector2D TestPoint);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Holds the box's minimum point.
		/// </summary>
		public FVector2D Min { get; set; } 
		
		/// <summary>
		/// Holds the box's maximum point.
		/// </summary>
		public FVector2D Max { get; set; } 
		
		/// <summary>
		/// Holds a flag indicating whether this box is valid.
		/// </summary>
		public bool bIsValid { get; set; } 
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Gets reference to the min or max of this bounding volume.
		/// @param Index The index into points of the bounding volume.
		/// @return A reference to a point of the bounding volume.
		/// </summary>
		public FVector2D this[int Index]
		{
			get => throw new NotImplementedException();
			set => throw new NotImplementedException();
		}

		
		/// <summary>
		/// Calculates the distance of a point to this box.
		/// @param Point The point.
		/// @return The distance.
		/// </summary>
		public float ComputeSquaredDistanceToPoint(FVector2D Point)
			=> E_FBox2D_ComputeSquaredDistanceToPoint(this, Point);
		
		
		/// <summary>
		/// Increase the bounding box volume.
		/// @param W The size to increase volume by.
		/// @return A new bounding box increased in size.
		/// </summary>
		public FBox2D ExpandBy(float W)
			=> E_FBox2D_ExpandBy(this, W);
		
		
		/// <summary>
		/// Gets the box area.
		/// @return Box area.
		/// @see GetCenter, GetCenterAndExtents, GetExtent, GetSize
		/// </summary>
		public float GetArea()
			=> E_FBox2D_GetArea(this);
		
		
		/// <summary>
		/// Gets the box's center point.
		/// @return Th center point.
		/// @see GetArea, GetCenterAndExtents, GetExtent, GetSize
		/// </summary>
		public FVector2D GetCenter()
			=> E_FBox2D_GetCenter(this);
		
		
		/// <summary>
		/// Get the center and extents
		/// @param center[out] reference to center point
		/// @param Extents[out] reference to the extent around the center
		/// @see GetArea, GetCenter, GetExtent, GetSize
		/// </summary>
		public void GetCenterAndExtents(FVector2D center, FVector2D Extents)
			=> E_FBox2D_GetCenterAndExtents(this, center, Extents);
		
		
		/// <summary>
		/// Calculates the closest point on or inside the box to a given point in space.
		/// @param Point The point in space.
		/// @return The closest point on or inside the box.
		/// </summary>
		public FVector2D GetClosestPointTo(FVector2D Point)
			=> E_FBox2D_GetClosestPointTo(this, Point);
		
		
		/// <summary>
		/// Set the initial values of the bounding box to Zero.
		/// </summary>
		public void Init()
			=> E_FBox2D_Init(this);
		
		
		/// <summary>
		/// Checks whether the given point is inside this box.
		/// @param Point The point to test.
		/// @return true if the point is inside this box, otherwise false.
		/// </summary>
		public bool IsInside(FVector2D TestPoint)
			=> E_FBox2D_IsInside(this, TestPoint);
		
		#endregion
		
	}