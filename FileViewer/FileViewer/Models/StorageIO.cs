using PCLStorage;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FileViewer.Models
{
    public class StorageIO
    {
        public string Path { get; set; }
        public string Name { get; set; }

        public StorageIO(string path, string name)
        {
            Path = path;
            Name = name;
        }

        public async Task<string> LoadTextAsync()
        {
            // ユーザーデータ保存フォルダー
            PCLStorage.IFolder localFolder = PCLStorage.FileSystem.Current.LocalStorage;

            // サブフォルダーを作成、または、取得する
            PCLStorage.IFolder subFolder = await localFolder.CreateFolderAsync(Path, PCLStorage.CreationCollisionOption.OpenIfExists);

            // ファイルを取得する
            PCLStorage.IFile file = await subFolder.GetFileAsync(Name);

            // テキストファイルを読み込む
            // ※ファイル冒頭に「using PCLStorage;」が必要
            return await file.ReadAllTextAsync();
        }

        public async Task<string> SaveTextAsync(string text)
        {
            // ユーザーデータ保存フォルダー
            PCLStorage.IFolder localFolder = PCLStorage.FileSystem.Current.LocalStorage;

            // サブフォルダーを作成、または、取得する
            PCLStorage.IFolder subFolder = await localFolder.CreateFolderAsync(Path, PCLStorage.CreationCollisionOption.OpenIfExists);

            // ファイルを作成、または、取得する
            PCLStorage.IFile file = await subFolder.CreateFileAsync(Path, PCLStorage.CreationCollisionOption.ReplaceExisting);

            // テキストをファイルに書き込む
            // ※冒頭に「using PCLStorage;」が必要
            await file.WriteAllTextAsync(text);

            return file.Path;
        }
    }
}
