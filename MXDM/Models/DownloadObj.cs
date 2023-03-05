using System;

namespace MXDM.Models;

public enum DownloadStatus
{
	/// <summary>
	/// created but not started yet
	/// </summary>
	Pending,
	/// <summary>
	/// Downloading
	/// </summary>
	Running,
	/// <summary>
	/// Temperrorly stope and will resume letter
	/// </summary>
	Paused,
	/// <summary>
	/// Cancell For ever
	/// </summary>
	Cancelled,
	/// <summary>
	/// Finsh Download successfully
	/// </summary>
	Complete,
	/// <summary>
	/// Failed due to some Error
	/// </summary>
	Failed
}
public class DownloadObj
{
	public string FileName { get; set; } = "";
	/// <summary>
	/// File size in Bytes
	/// </summary>
	public long Size { get; set; }
	public string? UrlAddress { get; set; }
	/// <summary>
	/// type of File (audio, vedio, pdf, program, mp4, mp3 ...etc)
	/// </summary>
	public string? Type { get; set; }
	public string? Description { get; set; }
	public DateTime AddedDate { get; set; } = DateTime.Now;
	public DateTime? LastTryDate {  get; set; } 
	public DownloadStatus Status { get; set; } = DownloadStatus.Pending;
	public string SaveTo { get; set; } = "";
	public string? ParentWebPage { get; set; }
	public int TransferRate { get; set; }
	



}
