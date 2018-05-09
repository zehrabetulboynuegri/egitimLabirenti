using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Data;
using Mono.Data.Sqlite;
using System.Data.SqlClient;


public class SoruGelme : MonoBehaviour 
{
	public GameObject model;
	string[] OyuncuCevap = new string[100];
	public int i=0;
	public Text Asıkkı, Bsıkkı, Csıkkı;
	public Text SoruPaneli;
	private string connectionString;
	public GameObject panel;
	public GameObject ks1,ks2,ks3,ks4,ks5,ks6,ks7,ks8,ks9,ks10,ks11,ks12,ks13,ks14,ks15,ks16,ks17,ks18;
	public GameObject s1a,s1b,s1c,s2a,s2b,s2c,s3a,s3b,s3c,s4a,s4b,s4c,s5a,s5b,s5c,s6a,s6b,s6c,s7a,s7b,s7c,s8a,s8b,s8c,s9a,s9b,s9c,s10a,s10b,s10c,
	s11a,s11b,s11c,s12a,s12b,s12c,s13a,s13b,s13c,s14a,s14b,s14c,s15a,s15b,s15c,s16a,s16b,s16c,s17a,s17b,s17c,s18a,s18b,s18c;

	// Use this for initialization
	public void Start () 
	{ 
		Debug.Log("bağlantı kurulacak");
		connectionString = "URI=file:" + Application.dataPath + "/EgitimLabirenti.db";
		panel.gameObject.SetActive (false);
	}

	// Update is called once per frame
	void Update () {
		
	}
		
	public void panelkapatmaAplaneaçma()
	{
		
		OyuncuCevap[i]= Asıkkı.text;
		Debug.Log (OyuncuCevap [i]);
		i++;

		using (IDbConnection dbConnection = new SqliteConnection (connectionString)) 
		{
			dbConnection.Open();
			Debug.Log("bağlantı kuruldu");
			using (IDbCommand dbCmd = dbConnection.CreateCommand())
			{
				string sqlQuery = "SELECT * FROM EgitimLabirenti where Soruid=1";

				dbCmd.CommandText = sqlQuery;

				using (IDataReader reader = dbCmd.ExecuteReader())
				{
					Debug.Log("veriler okunuyor");
					while (reader.Read())
					{
						Debug.Log("Veriler okundu");
						/* Debug.Log(reader.GetString(1) + "-" + reader.GetString(5)); */
						SoruPaneli.text = reader.GetString (1);
						Asıkkı.text =reader.GetString(2);
						Bsıkkı.text = reader.GetString (3);
						Csıkkı.text = reader.GetString (4);

					}
					reader.Close();
				}
			}
			dbConnection.Close ();

		}


		panel.gameObject.SetActive (false);
		s1a.gameObject.SetActive (false);
		s2a.gameObject.SetActive (false);
		s3a.gameObject.SetActive (false);
		s4a.gameObject.SetActive (false);
		s5a.gameObject.SetActive (false);
		s6a.gameObject.SetActive (false);
		s7a.gameObject.SetActive (false);
		s8a.gameObject.SetActive (false);
		s9a.gameObject.SetActive (false);
		s10a.gameObject.SetActive (false);
		s11a.gameObject.SetActive (false);
		s12a.gameObject.SetActive (false);
		s13a.gameObject.SetActive (false);
		s14a.gameObject.SetActive (false);
		s15a.gameObject.SetActive (false);
		s16a.gameObject.SetActive (false);
		s17a.gameObject.SetActive (false);
		s18a.gameObject.SetActive (false);
	}

	public void panelkapatmaBplaneaçma()
	{	
		OyuncuCevap[i]= Bsıkkı.text;
		Debug.Log (OyuncuCevap [i]);
		i++;

		panel.gameObject.SetActive (false);
		s1b.gameObject.SetActive (false);
		s2b.gameObject.SetActive (false);
		s3b.gameObject.SetActive (false);
		s4b.gameObject.SetActive (false);
		s5b.gameObject.SetActive (false);
		s6b.gameObject.SetActive (false);
		s7b.gameObject.SetActive (false);
		s8b.gameObject.SetActive (false);
		s9b.gameObject.SetActive (false);
		s10b.gameObject.SetActive (false);
		s11b.gameObject.SetActive (false);
		s12b.gameObject.SetActive (false);
		s13b.gameObject.SetActive (false);
		s14b.gameObject.SetActive (false);
		s15b.gameObject.SetActive (false);
		s16b.gameObject.SetActive (false);
		s17b.gameObject.SetActive (false);
		s18b.gameObject.SetActive (false);
	}

	public void panelkapatmaCplaneaçma()
	{
		OyuncuCevap[i]= Csıkkı.text;
		Debug.Log (OyuncuCevap [i]);
		i++;
		panel.gameObject.SetActive (false);
		s1c.gameObject.SetActive (false);
		s2c.gameObject.SetActive (false);
		s3c.gameObject.SetActive (false);
		s4c.gameObject.SetActive (false);
		s5c.gameObject.SetActive (false);
		s6c.gameObject.SetActive (false);
		s7c.gameObject.SetActive (false);
		s8c.gameObject.SetActive (false);
		s9c.gameObject.SetActive (false);
		s10c.gameObject.SetActive (false);
		s11c.gameObject.SetActive (false);
		s12c.gameObject.SetActive (false);
		s13c.gameObject.SetActive (false);
		s14c.gameObject.SetActive (false);
		s15c.gameObject.SetActive (false);
		s16c.gameObject.SetActive (false);
		s17c.gameObject.SetActive (false);
		s18c.gameObject.SetActive (false);
	}

	void OnCollisionEnter(Collision col) /*küpe değerse */
	{
		if (col.gameObject.tag=="s1") 
		{
			panel.gameObject.SetActive (true);
			/*Destroy (ks1); */
			ks1.gameObject.SetActive (false); /* gizlendi */
			using (IDbConnection dbConnection = new SqliteConnection (connectionString)) 
			{
				dbConnection.Open();
				Debug.Log("bağlantı kuruldu");
				using (IDbCommand dbCmd = dbConnection.CreateCommand())
				{
					string sqlQuery = "SELECT * FROM EgitimLabirenti where Soruid=1";

					dbCmd.CommandText = sqlQuery;

					using (IDataReader reader = dbCmd.ExecuteReader())
					{
						Debug.Log("veriler okunuyor");
						while (reader.Read())
						{
							Debug.Log("Veriler okundu");
							/* Debug.Log(reader.GetString(1) + "-" + reader.GetString(5)); */
							SoruPaneli.text = reader.GetString (1);
							Asıkkı.text =reader.GetString(2);
							Bsıkkı.text = reader.GetString (3);
							Csıkkı.text = reader.GetString (4);

						}
						reader.Close();
					}
				}
				dbConnection.Close ();

			}
		}

		if (col.gameObject.tag=="s2") 
		{
			s2a.gameObject.SetActive (true);
			s2b.gameObject.SetActive (true);
			s2c.gameObject.SetActive (true);
			panel.gameObject.SetActive (true);
			ks2.gameObject.SetActive (false); /* gizlendi */
			using (IDbConnection dbConnection = new SqliteConnection (connectionString)) 
			{
				dbConnection.Open();
				Debug.Log("bağlantı kuruldu");
				using (IDbCommand dbCmd = dbConnection.CreateCommand())
				{
					string sqlQuery = "SELECT * FROM EgitimLabirenti where Soruid=2";

					dbCmd.CommandText = sqlQuery;

					using (IDataReader reader = dbCmd.ExecuteReader())
					{
						Debug.Log("veriler okunuyor");
						while (reader.Read())
						{
							Debug.Log("Veriler okundu");
							/* Debug.Log(reader.GetString(1) + "-" + reader.GetString(5)); */
							SoruPaneli.text = reader.GetString (1);
							Asıkkı.text =reader.GetString(2);
							Bsıkkı.text = reader.GetString (3);
							Csıkkı.text = reader.GetString (4);

						}
						reader.Close();
					}
				}
				dbConnection.Close ();

			}
		}

		if (col.gameObject.tag=="s3") 
		{
			s3a.gameObject.SetActive (true);
			s3b.gameObject.SetActive (true);
			s3c.gameObject.SetActive (true);
			panel.gameObject.SetActive (true);
			ks3.gameObject.SetActive (false); /* gizlendi */
			using (IDbConnection dbConnection = new SqliteConnection (connectionString)) 
			{
				dbConnection.Open();
				Debug.Log("bağlantı kuruldu");
				using (IDbCommand dbCmd = dbConnection.CreateCommand())
				{
					string sqlQuery = "SELECT * FROM EgitimLabirenti where Soruid=3";

					dbCmd.CommandText = sqlQuery;

					using (IDataReader reader = dbCmd.ExecuteReader())
					{
						Debug.Log("veriler okunuyor");
						while (reader.Read())
						{
							Debug.Log("Veriler okundu");
							/* Debug.Log(reader.GetString(1) + "-" + reader.GetString(5)); */
							SoruPaneli.text = reader.GetString (1);
							Asıkkı.text =reader.GetString(2);
							Bsıkkı.text = reader.GetString (3);
							Csıkkı.text = reader.GetString (4);

						}
						reader.Close();
					}
				}
				dbConnection.Close ();

			}
		}

		if (col.gameObject.tag=="s4") 
		{
			s4a.gameObject.SetActive (true);
			s4b.gameObject.SetActive (true);
			s4c.gameObject.SetActive (true);
			panel.gameObject.SetActive (true);
			ks4.gameObject.SetActive (false); /* gizlendi */
			using (IDbConnection dbConnection = new SqliteConnection (connectionString)) 
			{
				dbConnection.Open();
				Debug.Log("bağlantı kuruldu");
				using (IDbCommand dbCmd = dbConnection.CreateCommand())
				{
					string sqlQuery = "SELECT * FROM EgitimLabirenti where Soruid=4";

					dbCmd.CommandText = sqlQuery;

					using (IDataReader reader = dbCmd.ExecuteReader())
					{
						Debug.Log("veriler okunuyor");
						while (reader.Read())
						{
							Debug.Log("Veriler okundu");
							/* Debug.Log(reader.GetString(1) + "-" + reader.GetString(5)); */
							SoruPaneli.text = reader.GetString (1);
							Asıkkı.text =reader.GetString(2);
							Bsıkkı.text = reader.GetString (3);
							Csıkkı.text = reader.GetString (4);

						}
						reader.Close();
					}
				}
				dbConnection.Close ();

			}
		}

		if (col.gameObject.tag=="s5") 
		{
			s5a.gameObject.SetActive (true);
			s5b.gameObject.SetActive (true);
			s5c.gameObject.SetActive (true);
			panel.gameObject.SetActive (true);
			ks5.gameObject.SetActive (false); /* gizlendi */
			using (IDbConnection dbConnection = new SqliteConnection (connectionString)) 
			{
				dbConnection.Open();
				Debug.Log("bağlantı kuruldu");
				using (IDbCommand dbCmd = dbConnection.CreateCommand())
				{
					string sqlQuery = "SELECT * FROM EgitimLabirenti where Soruid=5";

					dbCmd.CommandText = sqlQuery;

					using (IDataReader reader = dbCmd.ExecuteReader())
					{
						Debug.Log("veriler okunuyor");
						while (reader.Read())
						{
							Debug.Log("Veriler okundu");
							/* Debug.Log(reader.GetString(1) + "-" + reader.GetString(5)); */
							SoruPaneli.text = reader.GetString (1);
							Asıkkı.text =reader.GetString(2);
							Bsıkkı.text = reader.GetString (3);
							Csıkkı.text = reader.GetString (4);

						}
						reader.Close();
					}
				}
				dbConnection.Close ();

			}
		}

		if (col.gameObject.tag=="s6") 
		{
			s6a.gameObject.SetActive (true);
			s6b.gameObject.SetActive (true);
			s6c.gameObject.SetActive (true);
			panel.gameObject.SetActive (true);
			ks6.gameObject.SetActive (false); /* gizlendi */
			using (IDbConnection dbConnection = new SqliteConnection (connectionString)) 
			{
				dbConnection.Open();
				Debug.Log("bağlantı kuruldu");
				using (IDbCommand dbCmd = dbConnection.CreateCommand())
				{
					string sqlQuery = "SELECT * FROM EgitimLabirenti where Soruid=6";

					dbCmd.CommandText = sqlQuery;

					using (IDataReader reader = dbCmd.ExecuteReader())
					{
						Debug.Log("veriler okunuyor");
						while (reader.Read())
						{
							Debug.Log("Veriler okundu");
							/* Debug.Log(reader.GetString(1) + "-" + reader.GetString(5)); */
							SoruPaneli.text = reader.GetString (1);
							Asıkkı.text =reader.GetString(2);
							Bsıkkı.text = reader.GetString (3);
							Csıkkı.text = reader.GetString (4);

						}
						reader.Close();
					}
				}
				dbConnection.Close ();

			}
		}

		if (col.gameObject.tag=="s7") 
		{
			s7a.gameObject.SetActive (true);
			s7b.gameObject.SetActive (true);
			s7c.gameObject.SetActive (true);
			panel.gameObject.SetActive (true);
			ks7.gameObject.SetActive (false); /* gizlendi */
			using (IDbConnection dbConnection = new SqliteConnection (connectionString)) 
			{
				dbConnection.Open();
				Debug.Log("bağlantı kuruldu");
				using (IDbCommand dbCmd = dbConnection.CreateCommand())
				{
					string sqlQuery = "SELECT * FROM EgitimLabirenti where Soruid=7";

					dbCmd.CommandText = sqlQuery;

					using (IDataReader reader = dbCmd.ExecuteReader())
					{
						Debug.Log("veriler okunuyor");
						while (reader.Read())
						{
							Debug.Log("Veriler okundu");
							/* Debug.Log(reader.GetString(1) + "-" + reader.GetString(5)); */
							SoruPaneli.text = reader.GetString (1);
							Asıkkı.text =reader.GetString(2);
							Bsıkkı.text = reader.GetString (3);
							Csıkkı.text = reader.GetString (4);

						}
						reader.Close();
					}
				}
				dbConnection.Close ();

			}
		}

		if (col.gameObject.tag=="s8") 
		{
			s8a.gameObject.SetActive (true);
			s8b.gameObject.SetActive (true);
			s8c.gameObject.SetActive (true);
			panel.gameObject.SetActive (true);
			ks8.gameObject.SetActive (false); /* gizlendi */
			using (IDbConnection dbConnection = new SqliteConnection (connectionString)) 
			{
				dbConnection.Open();
				Debug.Log("bağlantı kuruldu");
				using (IDbCommand dbCmd = dbConnection.CreateCommand())
				{
					string sqlQuery = "SELECT * FROM EgitimLabirenti where Soruid=8";

					dbCmd.CommandText = sqlQuery;

					using (IDataReader reader = dbCmd.ExecuteReader())
					{
						Debug.Log("veriler okunuyor");
						while (reader.Read())
						{
							Debug.Log("Veriler okundu");
							/* Debug.Log(reader.GetString(1) + "-" + reader.GetString(5)); */
							SoruPaneli.text = reader.GetString (1);
							Asıkkı.text =reader.GetString(2);
							Bsıkkı.text = reader.GetString (3);
							Csıkkı.text = reader.GetString (4);

						}
						reader.Close();
					}
				}
				dbConnection.Close ();

			}
		}

		if (col.gameObject.tag=="s9") 
		{
			s9a.gameObject.SetActive (true);
			s9b.gameObject.SetActive (true);
			s9c.gameObject.SetActive (true);
			panel.gameObject.SetActive (true);
			ks9.gameObject.SetActive (false); /* gizlendi */
			using (IDbConnection dbConnection = new SqliteConnection (connectionString)) 
			{
				dbConnection.Open();
				Debug.Log("bağlantı kuruldu");
				using (IDbCommand dbCmd = dbConnection.CreateCommand())
				{
					string sqlQuery = "SELECT * FROM EgitimLabirenti where Soruid=9";

					dbCmd.CommandText = sqlQuery;

					using (IDataReader reader = dbCmd.ExecuteReader())
					{
						Debug.Log("veriler okunuyor");
						while (reader.Read())
						{
							Debug.Log("Veriler okundu");
							/* Debug.Log(reader.GetString(1) + "-" + reader.GetString(5)); */
							SoruPaneli.text = reader.GetString (1);
							Asıkkı.text =reader.GetString(2);
							Bsıkkı.text = reader.GetString (3);
							Csıkkı.text = reader.GetString (4);

						}
						reader.Close();
					}
				}
				dbConnection.Close ();

			}
		}

		if (col.gameObject.tag=="s10") 
		{
			s10a.gameObject.SetActive (true);
			s10b.gameObject.SetActive (true);
			s10c.gameObject.SetActive (true);
			panel.gameObject.SetActive (true);
			ks10.gameObject.SetActive (false); /* gizlendi */
			using (IDbConnection dbConnection = new SqliteConnection (connectionString)) 
			{
				dbConnection.Open();
				Debug.Log("bağlantı kuruldu");
				using (IDbCommand dbCmd = dbConnection.CreateCommand())
				{
					string sqlQuery = "SELECT * FROM EgitimLabirenti where Soruid=10";

					dbCmd.CommandText = sqlQuery;

					using (IDataReader reader = dbCmd.ExecuteReader())
					{
						Debug.Log("veriler okunuyor");
						while (reader.Read())
						{
							Debug.Log("Veriler okundu");
							/* Debug.Log(reader.GetString(1) + "-" + reader.GetString(5)); */
							SoruPaneli.text = reader.GetString (1);
							Asıkkı.text =reader.GetString(2);
							Bsıkkı.text = reader.GetString (3);
							Csıkkı.text = reader.GetString (4);

						}
						reader.Close();
					}
				}
				dbConnection.Close ();

			}
		}

		if (col.gameObject.tag=="s11") 
		{
			s11a.gameObject.SetActive (true);
			s11b.gameObject.SetActive (true);
			s11c.gameObject.SetActive (true);
			panel.gameObject.SetActive (true);
			ks11.gameObject.SetActive (false); /* gizlendi */
			using (IDbConnection dbConnection = new SqliteConnection (connectionString)) 
			{
				dbConnection.Open();
				Debug.Log("bağlantı kuruldu");
				using (IDbCommand dbCmd = dbConnection.CreateCommand())
				{
					string sqlQuery = "SELECT * FROM EgitimLabirenti where Soruid=11";

					dbCmd.CommandText = sqlQuery;

					using (IDataReader reader = dbCmd.ExecuteReader())
					{
						Debug.Log("veriler okunuyor");
						while (reader.Read())
						{
							Debug.Log("Veriler okundu");
							/* Debug.Log(reader.GetString(1) + "-" + reader.GetString(5)); */
							SoruPaneli.text = reader.GetString (1);
							Asıkkı.text =reader.GetString(2);
							Bsıkkı.text = reader.GetString (3);
							Csıkkı.text = reader.GetString (4);

						}
						reader.Close();
					}
				}
				dbConnection.Close ();

			}
		}

		if (col.gameObject.tag=="s12") 
		{
			s12a.gameObject.SetActive (true);
			s12b.gameObject.SetActive (true);
			s12c.gameObject.SetActive (true);
			panel.gameObject.SetActive (true);
			ks12.gameObject.SetActive (false); /* gizlendi */
			using (IDbConnection dbConnection = new SqliteConnection (connectionString)) 
			{
				dbConnection.Open();
				Debug.Log("bağlantı kuruldu");
				using (IDbCommand dbCmd = dbConnection.CreateCommand())
				{
					string sqlQuery = "SELECT * FROM EgitimLabirenti where Soruid=12";

					dbCmd.CommandText = sqlQuery;

					using (IDataReader reader = dbCmd.ExecuteReader())
					{
						Debug.Log("veriler okunuyor");
						while (reader.Read())
						{
							Debug.Log("Veriler okundu");
							/* Debug.Log(reader.GetString(1) + "-" + reader.GetString(5)); */
							SoruPaneli.text = reader.GetString (1);
							Asıkkı.text =reader.GetString(2);
							Bsıkkı.text = reader.GetString (3);
							Csıkkı.text = reader.GetString (4);

						}
						reader.Close();
					}
				}
				dbConnection.Close ();

			}
		}

		if (col.gameObject.tag=="s13") 
		{
			s13a.gameObject.SetActive (true);
			s13b.gameObject.SetActive (true);
			s13c.gameObject.SetActive (true);
			panel.gameObject.SetActive (true);
			ks13.gameObject.SetActive (false); /* gizlendi */

			using (IDbConnection dbConnection = new SqliteConnection (connectionString)) 
			{
				dbConnection.Open();
				Debug.Log("bağlantı kuruldu");
				using (IDbCommand dbCmd = dbConnection.CreateCommand())
				{
					string sqlQuery = "SELECT * FROM EgitimLabirenti where Soruid=13";

					dbCmd.CommandText = sqlQuery;

					using (IDataReader reader = dbCmd.ExecuteReader())
					{
						Debug.Log("veriler okunuyor");
						while (reader.Read())
						{
							Debug.Log("Veriler okundu");
							/* Debug.Log(reader.GetString(1) + "-" + reader.GetString(5)); */
							SoruPaneli.text = reader.GetString (1);
							Asıkkı.text =reader.GetString(2);
							Bsıkkı.text = reader.GetString (3);
							Csıkkı.text = reader.GetString (4);

						}
						reader.Close();
					}
				}
				dbConnection.Close ();

			}
		}

		if (col.gameObject.tag=="s14") 
		{
			s14a.gameObject.SetActive (true);
			s14b.gameObject.SetActive (true);
			s14c.gameObject.SetActive (true);
			panel.gameObject.SetActive (true);
			ks14.gameObject.SetActive (false); /* gizlendi */

			using (IDbConnection dbConnection = new SqliteConnection (connectionString)) 
			{
				dbConnection.Open();
				Debug.Log("bağlantı kuruldu");
				using (IDbCommand dbCmd = dbConnection.CreateCommand())
				{
					string sqlQuery = "SELECT * FROM EgitimLabirenti where Soruid=14";

					dbCmd.CommandText = sqlQuery;

					using (IDataReader reader = dbCmd.ExecuteReader())
					{
						Debug.Log("veriler okunuyor");
						while (reader.Read())
						{
							Debug.Log("Veriler okundu");
							/* Debug.Log(reader.GetString(1) + "-" + reader.GetString(5)); */
							SoruPaneli.text = reader.GetString (1);
							Asıkkı.text =reader.GetString(2);
							Bsıkkı.text = reader.GetString (3);
							Csıkkı.text = reader.GetString (4);

						}
						reader.Close();
					}
				}
				dbConnection.Close ();

			}
		}

		if (col.gameObject.tag=="s15") 
		{
			s15a.gameObject.SetActive (true);
			s15b.gameObject.SetActive (true);
			s15c.gameObject.SetActive (true);
			panel.gameObject.SetActive (true);
			ks15.gameObject.SetActive (false); /* gizlendi */

			using (IDbConnection dbConnection = new SqliteConnection (connectionString)) 
			{
				dbConnection.Open();
				Debug.Log("bağlantı kuruldu");
				using (IDbCommand dbCmd = dbConnection.CreateCommand())
				{
					string sqlQuery = "SELECT * FROM EgitimLabirenti where Soruid=15";

					dbCmd.CommandText = sqlQuery;

					using (IDataReader reader = dbCmd.ExecuteReader())
					{
						Debug.Log("veriler okunuyor");
						while (reader.Read())
						{
							Debug.Log("Veriler okundu");
							/* Debug.Log(reader.GetString(1) + "-" + reader.GetString(5)); */
							SoruPaneli.text = reader.GetString (1);
							Asıkkı.text =reader.GetString(2);
							Bsıkkı.text = reader.GetString (3);
							Csıkkı.text = reader.GetString (4);

						}
						reader.Close();
					}
				}
				dbConnection.Close ();

			}
		}

		if (col.gameObject.tag=="s16") 
		{
			s16a.gameObject.SetActive (true);
			s16b.gameObject.SetActive (true);
			s16c.gameObject.SetActive (true);
			panel.gameObject.SetActive (true);
			ks16.gameObject.SetActive (false); /* gizlendi */

			using (IDbConnection dbConnection = new SqliteConnection (connectionString)) 
			{
				dbConnection.Open();
				Debug.Log("bağlantı kuruldu");
				using (IDbCommand dbCmd = dbConnection.CreateCommand())
				{
					string sqlQuery = "SELECT * FROM EgitimLabirenti where Soruid=16";

					dbCmd.CommandText = sqlQuery;

					using (IDataReader reader = dbCmd.ExecuteReader())
					{
						Debug.Log("veriler okunuyor");
						while (reader.Read())
						{
							Debug.Log("Veriler okundu");
							/* Debug.Log(reader.GetString(1) + "-" + reader.GetString(5)); */
							SoruPaneli.text = reader.GetString (1);
							Asıkkı.text =reader.GetString(2);
							Bsıkkı.text = reader.GetString (3);
							Csıkkı.text = reader.GetString (4);

						}
						reader.Close();
					}
				}
				dbConnection.Close ();

			}
		}

		if (col.gameObject.tag=="s17") 
		{
			s17a.gameObject.SetActive (true);
			s17b.gameObject.SetActive (true);
			s17c.gameObject.SetActive (true);
			panel.gameObject.SetActive (true);
			ks17.gameObject.SetActive (false); /* gizlendi */

			using (IDbConnection dbConnection = new SqliteConnection (connectionString)) 
			{
				dbConnection.Open();
				Debug.Log("bağlantı kuruldu");
				using (IDbCommand dbCmd = dbConnection.CreateCommand())
				{
					string sqlQuery = "SELECT * FROM EgitimLabirenti where Soruid=17";

					dbCmd.CommandText = sqlQuery;

					using (IDataReader reader = dbCmd.ExecuteReader())
					{
						Debug.Log("veriler okunuyor");
						while (reader.Read())
						{
							Debug.Log("Veriler okundu");
							/* Debug.Log(reader.GetString(1) + "-" + reader.GetString(5)); */
							SoruPaneli.text = reader.GetString (1);
							Asıkkı.text =reader.GetString(2);
							Bsıkkı.text = reader.GetString (3);
							Csıkkı.text = reader.GetString (4);

						}
						reader.Close();
					}
				}
				dbConnection.Close ();

			}
		}

		if (col.gameObject.tag=="s18") 
		{
			s18a.gameObject.SetActive (true);
			s18b.gameObject.SetActive (true);
			s18c.gameObject.SetActive (true);
			panel.gameObject.SetActive (true);
			ks18.gameObject.SetActive (false); /* gizlendi */

			using (IDbConnection dbConnection = new SqliteConnection (connectionString)) 
			{
				dbConnection.Open();
				Debug.Log("bağlantı kuruldu");
				using (IDbCommand dbCmd = dbConnection.CreateCommand())
				{
					string sqlQuery = "SELECT * FROM EgitimLabirenti where Soruid=18";

					dbCmd.CommandText = sqlQuery;

					using (IDataReader reader = dbCmd.ExecuteReader())
					{
						Debug.Log("veriler okunuyor");
						while (reader.Read())
						{
							Debug.Log("Veriler okundu");
							/* Debug.Log(reader.GetString(1) + "-" + reader.GetString(5)); */
							SoruPaneli.text = reader.GetString (1);
							Asıkkı.text =reader.GetString(2);
							Bsıkkı.text = reader.GetString (3);
							Csıkkı.text = reader.GetString (4);

						}
						reader.Close();
					}
				}
				dbConnection.Close ();

			}
		}
	}
}
	
