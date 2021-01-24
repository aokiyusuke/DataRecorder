using System;

namespace DataRecorder.Models
{
    /// <summary>
    /// �Q�[�����̃X�e�[�^�X���Ǘ�����N���X�ł��B�Q�[������1�̃C���X�^���X�����쐬����܂���B
    /// </summary>
    public class GameStatus
    {
        #region // �v���p�e�B
        /// <summary>
        /// �m�[�c���̃X�R�A�i�[�p�z��̌��݂̃C���f�b�N�X
        /// </summary>
        public int noteIndex { get; set; } = 0;

        /// <summary>
        /// �G�l���M�[�ω��i�[�p�z��̌��݂̃C���f�b�N�X
        /// </summary>
        public int energyIndex { get; set; } = 0;

        /// <summary>
        /// ���ʃf�[�^�p�z��̃C���f�b�N�X
        /// </summary>
        public int mapIndex { get; set; } = 0;

        /// <summary>
        /// ���ʊJ�n���� (UNIX time[ms])
        /// </summary>
        public long startTime { get; set; } = 0;

        /// <summary>
        /// ���ʏI������ (UNIX time[ms])
        /// </summary>
        public long endTime { get; set; } = 0;

        /// <summary>
        /// �N���A����
        /// </summary>
        public string cleared { get; set; } = null;

        /// <summary>
        /// �I������
        /// </summary>
        public int endFlag { get; set; } = 0;

        /// <summary>
        /// pause��
        /// </summary>
        public int pauseCount { get; set; } = 0;

        /// <summary>
        /// StatusObject[Game] mode : �p�[�e�B���[�h
        /// </summary>
        public bool partyMode { get; set; } = false;

        /// <summary>
        /// StatusObject[Game] mode : �Q�[�����[�h
        /// </summary>
        public string mode { get; set; } = null;

        /// <summary>
        /// StatusObject[Game] mode : �Q�[���V�[��
        /// </summary>
        public string scene { get; set; } = null;

        /// <summary>
        /// StatusObject[BeatMap] �Ȗ�
        /// </summary>
        public string songName { get; set; } = null;

        /// <summary>
        /// StatusObject[BeatMap] �Ȃ̃T�u�^�C�g��
        /// </summary>
        public string songSubName { get; set; } = null;

        /// <summary>
        /// StatusObject[BeatMap] �Ȃ̍��
        /// </summary>
        public string songAuthorName { get; set; } = null;

        /// <summary>
        /// StatusObject[BeatMap] ���ʂ̍��
        /// </summary>
        public string levelAuthorName { get; set; } = null;

        /// <summary>
        /// StatusObject[BeatMap] ����ID(SHA-1)
        /// </summary>
        public string songHash { get; set; } = null;

        /// <summary>
        /// StatusObject[BeatMap] ����ID(Raw)
        /// </summary>
        public string levelId { get; set; } = null;

        /// <summary>
        /// StatusObject[BeatMap] �Ȃ�BPM
        /// </summary>
        public float songBPM { get; set; } = 0;

        /// <summary>
        /// StatusObject[BeatMap] ���ʂ�NJS
        /// </summary>
        public float noteJumpSpeed { get; set; } = 0;

        /// <summary>
        /// StatusObject[BeatMap] ���ʊJ�n�I�t�Z�b�g�l(�擾�o���Ă��Ȃ��H)
        /// </summary>
        public long songTimeOffset { get; set; } = 0;

        /// <summary>
        /// StatusObject[BeatMap] ���ʂ̒���[ms]
        /// </summary>
        public long length { get; set; } = 0;

        /// <summary>
        /// StatusObject[BeatMap] ���ʃv���C�J�n���̎��ԁB�ĊJ���ɍX�V�B(UNIX time[ms])
        /// </summary>
        public long start { get; set; } = 0;

        /// <summary>
        /// StatusObject[BeatMap] �ꎞ��~���̎���(UNIX time[ms])
        /// </summary>
        public long paused { get; set; } = 0;

        /// <summary>
        /// StatusObject[BeatMap] ���ʂ̓�Փx
        /// </summary>
        public string difficulty { get; set; } = null;

        /// <summary>
        /// StatusObject[BeatMap] ���ʂ̃m�[�c��
        /// </summary>
        public int notesCount { get; set; } = 0;

        /// <summary>
        /// StatusObject[BeatMap] ���ʂ̔��e��
        /// </summary>
        public int bombsCount { get; set; } = 0;

        /// <summary>
        /// StatusObject[BeatMap] ���ʂ̕ǂ̐�
        /// </summary>
        public int obstaclesCount { get; set; } = 0;

        /// <summary>
        /// StatusObject[BeatMap] ���݂�Mod�ł̍ő�X�R�A
        /// </summary>
        public int maxScore { get; set; } = 0;

        /// <summary>
        /// StatusObject[BeatMap] ���݂�Mod�ł̍ő僉���N
        /// </summary>
        public string maxRank { get; set; } = "E";

        /// <summary>
        /// StatusObject[BeatMap] ���ʂ̗v����
        /// </summary>
        public string environmentName { get; set; } = null;

        /// <summary>
        /// StatusObject[Performance] ���݂̃X�R�A
        /// </summary>
        public int score { get; set; } = 0;

        /// <summary>
        /// StatusObject[Performance] ���݂̃m�[�c���ŒB���\�ȍő�X�R�A
        /// </summary>
        public int currentMaxScore { get; set; } = 0;

        /// <summary>
        /// StatusObject[Performance] ���݂̃����N
        /// </summary>
        public string rank { get; set; } = "E";

        /// <summary>
        /// StatusObject[Performance] ���ݏ��������m�[�c��
        /// </summary>
        public int passedNotes { get; set; } = 0;

        /// <summary>
        /// StatusObject[Performance] ���݃q�b�g�����m�[�c��
        /// </summary>
        public int hitNotes { get; set; } = 0;

        /// <summary>
        /// StatusObject[Performance] ���݃~�X�����m�[�c��
        /// </summary>
        public int missedNotes { get; set; } = 0;

        /// <summary>
        /// StatusObject[Performance] �i���擾�j
        /// </summary>
        public int lastNoteScore { get; set; } = 0;

        /// <summary>
        /// StatusObject[Performance] ���ݏ����������e��
        /// </summary>
        public int passedBombs { get; set; } = 0;

        /// <summary>
        /// StatusObject[Performance] ���݃q�b�g�������e��
        /// </summary>
        public int hitBombs { get; set; } = 0;

        /// <summary>
        /// StatusObject[Performance] ���݂̃R���{��
        /// </summary>
        public int combo { get; set; } = 0;

        /// <summary>
        /// StatusObject[Performance] ���݂̍ő�R���{��
        /// </summary>
        public int maxCombo { get; set; } = 0;

        /// <summary>
        /// StatusObject[Performance] ���݂̃R���{�搔
        /// </summary>
        public int multiplier { get; set; } = 0;

        /// <summary>
        /// StatusObject[Performance] ���݂̃R���{�搔�̐i�s�
        /// </summary>
        public float multiplierProgress { get; set; } = 0;

        /// <summary>
        /// StatusObject[Performance] ���݂̃o�b�e���G�l���M�[�c��
        /// </summary>
        public int batteryEnergy { get; set; } = 1;

        /// <summary>
        /// StatusObject[Performance] ���݂̃G�l���M�[�c��
        /// </summary>
        public float energy { get; set; } = 0;

        /// <summary>
        /// StatusObject[Mods] Mod�搔
        /// </summary>
        public float modifierMultiplier { get; set; } = 1f;

        /// <summary>
        /// StatusObject[Mods] �ǂ̗L��
        /// </summary>
        public string modObstacles { get; set; } = "All";

        /// <summary>
        /// StatusObject[Mods] �m�[�~�X
        /// </summary>
        public bool modInstaFail { get; set; } = false;

        /// <summary>
        /// StatusObject[Mods] �m�[�t�@�E��
        /// </summary>
        public bool modNoFail { get; set; } = false;

        /// <summary>
        /// StatusObject[Mods] �o�b�e���G�l���M�[
        /// </summary>
        public bool modBatteryEnergy { get; set; } = false;

        /// <summary>
        /// StatusObject[Mods] �ő�o�b�e���c��(DB���L�^)
        /// </summary>
        public int batteryLives { get; set; } = 1;

        /// <summary>
        /// StatusObject[Mods] ��������
        /// </summary>
        public bool modDisappearingArrows { get; set; } = false;

        /// <summary>
        /// StatusObject[Mods] ���e����
        /// </summary>
        public bool modNoBombs { get; set; } = false;

        /// <summary>
        /// StatusObject[Mods] �Ȃ̑��x
        /// </summary>
        public string modSongSpeed { get; set; } = "Normal";

        /// <summary>
        /// StatusObject[Mods] �Ȃ̑��x��Mod�搔
        /// </summary>
        public float songSpeedMultiplier { get; set; } = 1f;

        /// <summary>
        /// StatusObject[Mods] ��󖳂�
        /// </summary>
        public bool modNoArrows { get; set; } = false;

        /// <summary>
        /// StatusObject[Mods] �S�[�X�g�m�[�c
        /// </summary>
        public bool modGhostNotes { get; set; } = false;

        /// <summary>
        /// StatusObject[Mods] �Z�C�o�[�N���b�V���Ŏ��s�H�iHidden)
        /// </summary>
        public bool modFailOnSaberClash { get; set; } = false;

        /// <summary>
        /// StatusObject[Mods] �����Ȋp�x(Hidden)
        /// </summary>
        public bool modStrictAngles { get; set; } = false;

        /// <summary>
        /// StatusObject[Mods] Does something (Hidden)
        /// </summary>
        public bool modFastNotes { get; set; } = false;

        /// <summary>
        /// StatusObject[Player settings] �ÓI���C�g
        /// </summary>
        public bool staticLights { get; set; } = false;

        /// <summary>
        /// StatusObject[Player settings] ������
        /// </summary>
        public bool leftHanded { get; set; } = false;

        /// <summary>
        /// StatusObject[Player settings] �v���C���[�̍���
        /// </summary>
        public float playerHeight { get; set; } = 1.7f;

        /// <summary>
        /// StatusObject[Player settings] �m�[�c�J�b�g����
        /// </summary>
        public float sfxVolume { get; set; } = 0.7f;

        /// <summary>
        /// StatusObject[Player settings] �m�[�c�J�b�g���̔j�ЗL��
        /// </summary>
        public bool reduceDebris { get; set; } = false;

        /// <summary>
        /// StatusObject[Player settings] �e�L�X�g��HUD����
        /// </summary>
        public bool noHUD { get; set; } = false;

        /// <summary>
        /// StatusObject[Player settings] Advanced HUD
        /// </summary>
        public bool advancedHUD { get; set; } = false;

        /// <summary>
        /// StatusObject[Player settings] ���s���Ɏ������X�^�[�g
        /// </summary>
        public bool autoRestart { get; set; } = false;
        #endregion
        #region // �萔
        /// <summary>
        /// noteScore�z�񏉊����T�C�Y (�K�v�Ȕz��T�C�Y�̓m�[�c���{���e��)
        /// </summary>
        private const int defaultNoteScoreSize = 1; //3000 //1-24 �m�[�c�J�b�g�L�^�����ŗp�R�����g�A�E�g

        /// <summary>
        /// noteScore�z��ǉ��T�C�Y
        /// </summary>
        private const int addNoteScoreSize = 500;

        /// <summary>
        /// ���ʃf�[�^�p�z�񏉊����T�C�Y
        /// </summary>
        private const int defaultMapDataSize = 1; //3000 //1-24 �m�[�c�J�b�g�L�^�����ŗp�R�����g�A�E�g

        /// <summary>
        /// ���ʃf�[�^�p�z��ǉ��T�C�Y
        /// </summary>
        private const int addMapDataSize = 500;

        /// <summary>
        /// �G�l���M�[�ω��i�[�p�z�񏉊����T�C�Y
        /// </summary>
        private const int defaultEnergyDataSize = 1; //1000 //1-24 �m�[�c�J�b�g�L�^�����ŗp�R�����g�A�E�g

        /// <summary>
        /// �G�l���M�[�ω��i�[�p�z��ǉ��T�C�Y
        /// </summary>
        private const int addEnergyDataSize = 500;
        #endregion
        #region // �����o�ϐ�
        /// <summary>
        /// �m�[�c���̃X�R�A�i�[�p�z��
        /// </summary>
        private NoteDataEntity[] noteScores = new NoteDataEntity[defaultNoteScoreSize];

        /// <summary>
        /// �G�l���M�[�ω��i�[�p�z��
        /// </summary>
        private EnergyDataEntity[] energyDatas = new EnergyDataEntity[defaultEnergyDataSize];

        /// <summary>
        /// ���ʃf�[�^�p�z��
        /// </summary>
        private MapDataEntity[] mapDatas = new MapDataEntity[defaultMapDataSize];

        #endregion
        #region // �R���X�g���N�^
        public GameStatus()
        {
            // �m�[�c�E�G�l���M�[�i�[�ϐ��̏�����
            for (int i = 0; i < defaultNoteScoreSize; ++i)
                noteScores[i] = new NoteDataEntity();
            for (int i = 0; i < defaultEnergyDataSize; ++i)
                energyDatas[i] = new EnergyDataEntity();
        }
        #endregion
        #region // �p�u���b�N���\�b�h
        /// <summary>
        /// �G�l���M�[�ω��i�[�p�z��̃��T�C�Y
        /// </summary>
        public void EnergyDataResize()
        {
            Array.Resize(ref energyDatas, energyDatas.Length + addEnergyDataSize);
        }

        /// <summary>
        /// �m�[�c���̃X�R�A�i�[�p�z��̃��T�C�Y
        /// </summary>
        public void NoteDataResize(int size)
        {
            Array.Resize(ref noteScores, size + addNoteScoreSize);
        }

        /// <summary>
        /// ���ʃf�[�^�p�z��̃��T�C�Y
        /// </summary>
        public void MapDataResize(int size)
        {
            Array.Resize(ref mapDatas, size + addMapDataSize);
        }

        /// <summary>
        /// �m�[�c���̃X�R�A�i�[�p�z�񂩂猻�݂̃C���f�b�N�X�̓��e�����o��
        /// </summary>
        public NoteDataEntity NoteDataGet()
        {
            if (noteScores[noteIndex] == null)
                noteScores[noteIndex] = new NoteDataEntity();
            return noteScores[noteIndex];
        }

        /// <summary>
        /// �G�l���M�[�ω��i�[�p�z�񂩂猻�݂̃C���f�b�N�X�̓��e�����o��
        /// </summary>
        public EnergyDataEntity EnergyDataGet()
        {
            if (energyDatas[energyIndex] == null)
                energyDatas[energyIndex] = new EnergyDataEntity();
            return energyDatas[energyIndex];
        }

        /// <summary>
        /// ���ʃf�[�^�p�z�񂩂猻�݂̃C���f�b�N�X�̓��e�����o��
        /// </summary>
        public MapDataEntity MapDataGet()
        {
            if (mapDatas[mapIndex] == null)
                mapDatas[mapIndex] = new MapDataEntity();
            return mapDatas[mapIndex];
        }

        /// <summary>
        /// �m�[�c���̃X�R�A�i�[�p�z��̃C���f�b�N�X���C���N�������g
        /// </summary>
        public void NoteDataIndexUp()
        {
            noteIndex++;
            if (noteIndex >= noteScores.Length) {
                NoteDataResize(noteScores.Length);
            }
        }

        /// <summary>
        /// �G�l���M�[�ω��i�[�p�z��̃C���f�b�N�X���C���N�������g
        /// </summary>
        public void EnergyDataIndexUp()
        {
            energyIndex++;
            if (energyIndex >= energyDatas.Length) {
                EnergyDataResize();
            }
        }

        /// <summary>
        /// ���ʃf�[�^�p�z��̃C���f�b�N�X���C���N�������g
        /// </summary>
        public void MapDataIndexUp()
        {
            mapIndex++;
            if (mapIndex >= mapDatas.Length) {
                MapDataResize(mapDatas.Length);
            }
        }

        /// <summary>
        /// GameStatus�̃��Z�b�g
        /// </summary>
        public void ResetGameStatus()
        {
            this.startTime = 0;
            this.endTime = 0;
            this.cleared = null;
            this.endFlag = 0;
            this.pauseCount = 0;
            this.partyMode = false;
            this.mode = null;
            this.scene = null;
            this.songName = null;
            this.songSubName = null;
            this.songAuthorName = null;
            this.levelAuthorName = null;
            this.songHash = null;
            this.levelId = null;
            this.songBPM = 0;
            this.noteJumpSpeed = 0;
            this.songTimeOffset = 0;
            this.length = 0;
            this.start = 0;
            this.paused = 0;
            this.difficulty = null;
            this.notesCount = 0;
            this.bombsCount = 0;
            this.obstaclesCount = 0;
            this.maxScore = 0;
            this.maxRank = "E";
            this.environmentName = null;
            this.score = 0;
            this.currentMaxScore = 0;
            this.rank = "E";
            this.passedNotes = 0;
            this.hitNotes = 0;
            this.missedNotes = 0;
            this.lastNoteScore = 0;
            this.passedBombs = 0;
            this.hitBombs = 0;
            this.combo = 0;
            this.maxCombo = 0;
            this.multiplier = 0;
            this.multiplierProgress = 0;
            this.batteryEnergy = 1;
            this.energy = 0;
            this.modifierMultiplier = 1f;
            this.modObstacles = "All";
            this.modInstaFail = false;
            this.modNoFail = false;
            this.modBatteryEnergy = false;
            this.batteryLives = 1;
            this.modDisappearingArrows = false;
            this.modNoBombs = false;
            this.modSongSpeed = "Normal";
            this.songSpeedMultiplier = 1f;
            this.modNoArrows = false;
            this.modGhostNotes = false;
            this.modFailOnSaberClash = false;
            this.modStrictAngles = false;
            this.modFastNotes = false;
            this.staticLights = false;
            this.leftHanded = false;
            this.playerHeight = 1.7f;
            this.sfxVolume = 0.7f;
            this.reduceDebris = false;
            this.noHUD = false;
            this.advancedHUD = false;
            this.autoRestart = false;
            ResetNoteCut();
            ResetEnergy();
        }
        #endregion
        #region // �v���C�x�[�g���\�b�h
        /// <summary>
        /// �m�[�c���̃X�R�A�i�[�p�z������Z�b�g
        /// </summary>
        private void ResetNoteCut()
        {
            noteIndex = 0;
            for (int i = 0; i < noteScores.Length; i++) {
                if (noteScores[i] == null) {
                    noteScores[i] = new NoteDataEntity();
                }
                else {
                    noteScores[i].bs_event = "";
                    noteScores[i].time = 0;
                    noteScores[i].cutTime = 0;
                    noteScores[i].score = 0;
                    noteScores[i].currentMaxScore = 0;
                    noteScores[i].rank = "E";
                    noteScores[i].passedNotes = 0;
                    noteScores[i].hitNotes = 0;
                    noteScores[i].missedNotes = 0;
                    noteScores[i].lastNoteScore = 0;
                    noteScores[i].passedBombs = 0;
                    noteScores[i].hitBombs = 0;
                    noteScores[i].combo = 0;
                    noteScores[i].maxCombo = 0;
                    noteScores[i].multiplier = 0;
                    noteScores[i].multiplierProgress = 0;
                    noteScores[i].batteryEnergy = 1;
                    noteScores[i].noteID = null;
                    noteScores[i].noteType = null;
                    noteScores[i].noteCutDirection = null;
                    noteScores[i].noteLine = null;
                    noteScores[i].noteLayer = null;
                    noteScores[i].speedOK = null;
                    noteScores[i].directionOK = null;
                    noteScores[i].saberTypeOK = null;
                    noteScores[i].wasCutTooSoon = null;
                    noteScores[i].initialScore = null;
                    noteScores[i].beforeScore = null;
                    noteScores[i].afterScore = null;
                    noteScores[i].cutDistanceScore = null;
                    noteScores[i].finalScore = null;
                    noteScores[i].cutMultiplier = null;
                    noteScores[i].saberSpeed = null;
                    noteScores[i].saberDirX = null;
                    noteScores[i].saberDirY = null;
                    noteScores[i].saberDirZ = null;
                    noteScores[i].saberType = null;
                    noteScores[i].swingRating = null;
                    noteScores[i].swingRatingFullyCut = null;
                    noteScores[i].timeDeviation = null;
                    noteScores[i].cutDirectionDeviation = null;
                    noteScores[i].cutPointX = null;
                    noteScores[i].cutPointY = null;
                    noteScores[i].cutPointZ = null;
                    noteScores[i].cutNormalX = null;
                    noteScores[i].cutNormalY = null;
                    noteScores[i].cutNormalZ = null;
                    noteScores[i].cutDistanceToCenter = null;
                    noteScores[i].timeToNextBasicNote = null;
                }
            }
        }

        /// <summary>
        /// �G�l���M�[�ω��i�[�p�z������Z�b�g
        /// </summary>
        private void ResetEnergy()
        {
            energyIndex = 0;
            for (int i = 0; i < energyDatas.Length; i++) {
                if (energyDatas[i] == null) {
                    energyDatas[i] = new EnergyDataEntity();
                }
                else {
                    energyDatas[i].time = 0;
                    energyDatas[i].energy = 0;
                }
            }
        }

        #endregion
    }
}
