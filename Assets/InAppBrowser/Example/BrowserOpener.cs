﻿using UnityEngine;
using System.Collections;

public class BrowserOpener : MonoBehaviour {

	public string pageToOpen;

	// check readme file to find out how to change title, colors etc.
	public void OnButtonClicked() {
		InAppBrowser.DisplayOptions options = new InAppBrowser.DisplayOptions();
		options.displayURLAsPageTitle = false;
		options.pageTitle = "InAppBrowser example";

		InAppBrowser.OpenURL(pageToOpen, options);
		Debug.Log("HERE ");
	}

	public void OnClearCacheClicked() {
		InAppBrowser.ClearCache();
	}
}
